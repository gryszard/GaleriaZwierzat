namespace GaleriaZwierzat;

public partial class Gallery : Form
{
    private List<Picture> Pictures;

    public static List<Picture> GetPictures()
    {
        return PicturesManager.GetPicturesFromDb();
    }

    public void DeletePicture(int id)
    {
        PicturesManager.DeletePictureFromDb(id);
    }

    public void AddPicture(Picture picture)
    {
        PicturesManager.AddTitle(picture.Title);
        PicturesManager.SavePictureToDb(picture);
    }

    public void DisplayPictures()
    {
        tableLayoutPanel1.Controls.Clear();

        for (var i = 0; i < Pictures.Count; i++)
        {
            var imageBytes = Convert.FromBase64String(Pictures[i].PictureBase64);
            using MemoryStream ms = new(imageBytes);
            var image = Image.FromStream(ms);
            var resizedImage = (Image)new Bitmap(image, GetScaledSize(image));
            var pictureBox = new PictureBox
            {
                Image = resizedImage,
                Size = new Size(resizedImage.Width, resizedImage.Height)
            };
            var button = new Button
            {
                Size = new Size(125, 29),
                Text = "usuń zdjęcie",
                Tag = Pictures[i].Id
            };

            button.Click += buttonDeletePicture_Click;

            tableLayoutPanel1.Controls.Add(pictureBox, 0, i);
            tableLayoutPanel1.Controls.Add(button, 1, i);
        }
    }

    #region Helpers

    private Picture pictureToAdd = new();

    public Gallery()
    {
        InitializeComponent();

        var minimumWidth = panelPicture.Location.X + panelPicture.Size.Width + 100;
        var minimumHeight = panelPicture.Location.Y + panelPicture.Size.Height + 100;
        MinimumSize = new Size(minimumWidth, minimumHeight);

        Pictures = GetPictures();
        DisplayPictures();
    }

    private void buttonAddPicture_Click(object sender, EventArgs e)
    {
        panelPicture.Visible = true;
    }

    private void buttonAddTitle_Click(object sender, EventArgs e)
    {
        panelTitle.Visible = true;
    }

    private void buttonCancelTitle_Click(object sender, EventArgs e)
    {
        panelTitle.Visible = false;
    }

    private void buttonCancelPicture_Click(object sender, EventArgs e)
    {
        panelPicture.Visible = false;
        panelTitle.Visible = false;
    }

    private void buttonSaveTitle_Click(object sender, EventArgs e)
    {
        var title = textBoxTitle.Text;

        if (string.IsNullOrWhiteSpace(title) || title.Length > 200)
        {
            pictureToAdd.Title = null;
            return;
        }

        pictureToAdd.Title = title;
        panelTitle.Visible = false;
    }

    private void buttonUploadPicture_Click(object sender, EventArgs e)
    {
        var fileDialog = new OpenFileDialog();
        fileDialog.Filter = "Images|*.jpg;*.png";
        var dialogResult = fileDialog.ShowDialog(this);

        if (dialogResult != DialogResult.OK)
        {
            return;
        }

        var bytes = File.ReadAllBytes(fileDialog.FileName);
        pictureToAdd.PictureBase64 = Convert.ToBase64String(bytes);
    }

    private void buttonSavePicture_Click(object sender, EventArgs e)
    {
        if (pictureToAdd.Title == null || pictureToAdd.PictureBase64 == null)
        {
            return;
        }

        AddPicture(pictureToAdd);
        pictureToAdd = new();

        Pictures = GetPictures();
        DisplayPictures();
    }

    private void buttonDeletePicture_Click(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var id = (int)button.Tag;

        var dialogResult = MessageBox.Show("Delete: " + id, "Caption", MessageBoxButtons.YesNo);
        if (dialogResult != DialogResult.Yes)
        {
            return;
        }

        DeletePicture(id);
        Pictures = GetPictures();
        DisplayPictures();
    }

    private static Size GetScaledSize(Image image)
    {
        var newWidth = 300;
        var proportion = (double)image.Height / image.Width;
        var newHeight = (int)(newWidth * proportion);

        return new Size(newWidth, newHeight);
    }

    #endregion Helpers
}

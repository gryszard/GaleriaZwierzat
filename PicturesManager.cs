using Microsoft.Data.Sqlite;

namespace GaleriaZwierzat;

internal static class PicturesManager
{
    private static Picture? pictureToSave = null;

    public static void AddTitle(string title)
    {
        pictureToSave ??= new();
        pictureToSave.Title = title;
    }

    public static void SavePictureToDb(Picture picture)
    {
        pictureToSave!.PictureBase64 = picture.PictureBase64;

        using var connection = new SqliteConnection("Data Source=db.db");
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Picture (Title, Picture) VALUES ($title, $picture)";
        command.Parameters.AddWithValue("$title", picture.Title);
        command.Parameters.AddWithValue("$picture", picture.PictureBase64);
        command.ExecuteNonQuery();
    }

    public static void DeletePictureFromDb(int id)
    {
        using var connection = new SqliteConnection("Data Source=db.db");
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Picture WHERE Id = $id";
        command.Parameters.AddWithValue("$id", id);
        command.ExecuteNonQuery();
    }

    public static List<Picture> GetPicturesFromDb()
    {
        using var connection = new SqliteConnection("Data Source=db.db");
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Picture";

        var pictures = new List<Picture>();
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            pictures.Add(new Picture 
            { 
                Id = (int)(long)reader["Id"],
                Title = (string)reader["Title"],
                PictureBase64 = (string)reader["Picture"],
            });
        }

        return pictures;
    }
}

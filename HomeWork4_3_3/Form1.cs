using System.IO.Compression;

namespace HomeWork4_3_3;

public partial class Form1 : Form {

    private string? foundFullFilePath = null;

    public Form1() {
        InitializeComponent();
    }

    private void btnSearchFile_Click(object sender, EventArgs e) {
        txtFileContent.Text = "";
        txtCompressedFilePath.Text = "";
        txtCompressedFileSize.Text = "";
        txtInputFileSize.Text = "";
        txtSearchResult.Text = "";
        gbFileView.Enabled = false;
        gbFileCompress.Enabled = false;
        foundFullFilePath = null;

        Application.DoEvents();

        var opts = new EnumerationOptions {
            IgnoreInaccessible = true,
            RecurseSubdirectories = true,
        };

        foreach (var item in System.IO.Directory.EnumerateFiles(@"c:\", txtSearchFileName.Text, opts)) {
            foundFullFilePath = item;
            break;
        }

        if (foundFullFilePath == null) {
            txtSearchResult.Text = "Файл не знайдено";
        } else {
            txtSearchResult.Text = foundFullFilePath;
            gbFileView.Enabled = true;
            gbFileCompress.Enabled = true;
        }
    }

    private void btnReadFile_Click(object sender, EventArgs e) {
        if (!System.IO.File.Exists(foundFullFilePath)) {
            MessageBox.Show($"Файл '{foundFullFilePath}' вже не існує");
            return;
        }

        var reader = new StreamReader(foundFullFilePath);
        txtFileContent.Text = reader.ReadToEnd();
        reader.Close();
    }

    private void btnCompressFile_Click(object sender, EventArgs e) {
        if (!System.IO.File.Exists(foundFullFilePath)) {
            MessageBox.Show($"Файл '{foundFullFilePath}' вже не існує");
            return;
        }

        var assumedCompressFilePath = foundFullFilePath + ".zip";
        int fileNumberCounter = 1;
        while (System.IO.File.Exists(assumedCompressFilePath)) {
            assumedCompressFilePath = $"{foundFullFilePath}-{fileNumberCounter}.zip";
            fileNumberCounter++;
        }

        using FileStream streamCompressed = File.Create(assumedCompressFilePath);
        using FileStream streamSource = File.OpenRead(foundFullFilePath);
        using GZipStream compressor = new GZipStream(streamCompressed, CompressionMode.Compress);

        int theByte = streamSource.ReadByte();
        while (theByte != -1) {
            compressor.WriteByte((byte)theByte);
            theByte = streamSource.ReadByte();
        }

        compressor.Close();
        streamCompressed.Close();
        streamSource.Close();

        var fiSource = new FileInfo(foundFullFilePath);
        var fiCompressed = new FileInfo(assumedCompressFilePath);

        txtInputFileSize.Text = fiSource.Length.ToString();
        txtCompressedFileSize.Text = fiCompressed.Length.ToString();
        txtCompressedFilePath.Text = assumedCompressFilePath;
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Net;

public class WebServer
{
    //----------Private Variables----------//
    private WebClient _client;
    private string _serverAddress;

    private string _downloadFileSaveLocation;

    //----------Public Variables----------//
    public bool IsConnectedToServer
    {
        get
        {
            try
            {
                _client.OpenRead(_serverAddress);
                return true;
            }
            catch (WebException) { return false; }
        }
    }

    //----------Constructors----------//
    public WebServer(string serverAddress)
    {
        _client = new WebClient();
        _client.DownloadDataCompleted += _client_DownloadDataCompleted;
        _client.DownloadProgressChanged += _client_DownloadProgressChanged;
        _client.UploadDataCompleted += _client_UploadDataCompleted;
        _client.UploadProgressChanged += _client_UploadProgressChanged;

        _serverAddress = serverAddress;
    }

    //----------Public Methods----------//
    public void DownloadFile(string urlpath, string filepath)
    {
        _downloadFileSaveLocation = filepath;
        if (!File.Exists(_downloadFileSaveLocation))
        {
            Uri uri = new Uri(_serverAddress + urlpath);
            _client.DownloadDataAsync(uri); 
        }
        else
            System.Windows.Forms.MessageBox.Show("File already exists!");
    }

    public void UploadFile(string filepath, string urlpath)
    {

    }

    //----------Events----------//
    //---Download---//
    private void _client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
        onDownloadProgressChanged(e);
    }

    public event EventHandler<DownloadProgressChangedEventArgs> DownloadProgressChanged;
    protected virtual void onDownloadProgressChanged(DownloadProgressChangedEventArgs e)
    {
        EventHandler<DownloadProgressChangedEventArgs> handler = DownloadProgressChanged;
        if (handler != null)
            handler(this, e);
    }

    private void _client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
    {
        if (!e.Cancelled && e.Error == null)
            File.WriteAllBytes(_downloadFileSaveLocation, e.Result);
        else
            System.Windows.Forms.MessageBox.Show(e.Error.StackTrace, e.Error.Message);
    }

    //---Upload---//
    private void _client_UploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
    {

    }

    private void _client_UploadDataCompleted(object sender, UploadDataCompletedEventArgs e)
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using System.IO;
using System.Net.Http;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;


namespace Cromic_Browser
{
    class HttpDownloadClient 
    {
        static object fileLocker = new object();

        object statusLocker = new object();

                                         // The Url of the file to be downloaded.
        public Uri Url { get; private set; }

                                            // The local path to store the file.
                                            // If there is no file with the same name, a new file will be created.
        public string DownloadPath { get; set; }

                                            // Ask the server for the file size and store it.
                                           // Use the CheckUrl method to initialize this property internally.
        public long TotalSize { get; set; }

        public ICredentials Credentials { get; set; }

        public IWebProxy Proxy { get; set; }

                                            /// <summary>
                                                /// Specify whether the remote server supports "Accept-Ranges" header.
                                                 /// Use the CheckUrl method to initialize this property internally.
                                            /// </summary>
        public bool IsRangeSupported { get; set; }

                                       // The properties StartPoint and EndPoint can be used in the multi-thread download scenario, and
                                       // every thread starts to download a specific block of the whole file. 
        public long StartPoint { get; set; }

        public long EndPoint { get; set; }


                                         // The size of downloaded data that has been writen to local file.
        public long DownloadedSize { get; private set; }

        public int CachedSize { get; private set; }

        public bool HasChecked { get; set; }

        // Store the used time spent in downloading data. The value does not include
        // the paused time and it will only be updated when the download is paused, 
        // canceled or completed.
        private TimeSpan usedTime = new TimeSpan();

        private DateTime lastStartTime;

        /// <summary>
        /// If the status is Downloading, then the total time is usedTime. Else the total 
        /// should include the time used in current download thread.
        /// </summary>

        //---------------------------------- Global Variable Declaration completes here------------------------------------

        public async void downloadFile(String url)
        {
            
            HttpClient Client = new HttpClient();
            //Client.GetAsync += clien_openReadCompleted;
            Client.GetAsync(new Uri("http://localhost/mydata/login/Events/Armageddon.pdf"));
            
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            savePicker.FileTypeChoices.Add("PDF", new List<string>() { ".pdf" });
            savePicker.SuggestedFileName = "New Document";
            savePicker.PickSaveFileAndContinue();
            StorageFile SF =await KnownFolders.PicturesLibrary.CreateFileAsync("Guide.pdf", CreationCollisionOption.ReplaceExisting);
            var fs = await SF.OpenAsync(FileAccessMode.ReadWrite);
            StorageStreamTransaction transaction = await SF.OpenTransactedWriteAsync();
            DataWriter datawriter = new DataWriter(transaction.Stream);
           // datawriter.WriteBytes(buf);
            transaction.Stream.Size = await datawriter.StoreAsync();
            await transaction.CommitAsync();
            await Windows.System.Launcher.LaunchFileAsync(SF);
        }

     
        
    }
}

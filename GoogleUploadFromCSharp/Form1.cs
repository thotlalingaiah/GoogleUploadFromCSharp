using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using static Google.Apis.Drive.v3.DriveService;

namespace GoogleUploadFromCSharp
{
    public partial class Form1 : Form
    {
        string credentialKey = @"C:\Users\IT\Downloads\csharpuploadfile-1ed389976584.json";
        DriveService service;
        GoogleCredential credential;
        string GoogleFolderID = "1YXom5WewKo9TOdjIup_F3lJ5gC5H62hk";
        public Form1()
        {
            InitializeComponent();
            CreateDriveService();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All Files(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = ofd.FileName;
                }
            }
        }

        private DriveService CreateDriveService()
        {
            using (var stream = new FileStream(credentialKey, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream);
            }
            if (credential.IsCreateScopedRequired)
            {
                credential = credential.CreateScoped(
                     new[]
                     {
                         ScopeConstants.DriveFile,
                         ScopeConstants.DriveReadonly,
                     }

                    );
            }
            service = new DriveService(
                new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "C# Upload File"

                }

                );
            return service;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = Path.GetFileName(txtFile.Text),
                Parents = new List<string>() { GoogleFolderID }
            };

            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(txtFile.Text, FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, "");
                request.Fields = "id";
                var response = request.Upload();
                if (response.Status != Google.Apis.Upload.UploadStatus.Completed)
                {
                    MessageBox.Show(response.ToString());
                }
                else
                {
                    txtID.Text = request.ResponseBody.Id.ToString();

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var req = service.Files.Delete(txtID.Text);
            string response = req.Execute();
            if (response != null)
                MessageBox.Show(response.ToString());

        }

        private async void btnFileList_Click(object sender, EventArgs e)
        {
            try
            {


                var fileList = service.Files.List();
                fileList.Q = $"mimeType!='application/vnd.google-apps.folder' and '{GoogleFolderID}' in parents";
                fileList.Fields = "nextPageToken,files(id,name,size,mimeType,createdTime)";
                var result = new List<Google.Apis.Drive.v3.Data.File>();
                string pageToken = null;
                do
                {
                    fileList.PageToken = pageToken;
                    var fileResult = await fileList.ExecuteAsync();
                    var files = fileResult.Files;
                    pageToken = fileResult.NextPageToken;
                    result.AddRange(files);

                } while (pageToken != null);

                foreach (var item in result)
                {
                    string filedesc = item.Name + " " + item.Id + Environment.NewLine;
                    txtfileList.Text += filedesc;
                }
            }
            catch (Exception ex)
            {

                //   throw;
            }

        }
    }
}

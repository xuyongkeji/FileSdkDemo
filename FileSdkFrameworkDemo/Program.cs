using FileSdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSdkFrameworkDemo
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            /*初始化文件上传参数*/
            FileUploadSdk fileUploadSdk = new FileUploadSdk("http://192.168.1.59:5050", "200506-102516-243533-025967C88B2");

            /*获取文件上传参数*/
            fileUploadSdk.GetUploadParams();

            /*调用生成二维码*/
            QrCodeRequest paramQrCode = new QrCodeRequest()
            {
                content = "生成二维码",
                description = "即可将立即加快建立科技",
                fileName = "生成二维码",
                operType = "add",
                licId = "1",
                orgId = "2",
                orgName = "重庆旭永科技发展有限公司",
                pathCustomDirName = "/test",
                tableBsId = 123,
                tableName = "无业务名",
                title = "无标题",
                userId = "12",
                userName = "娜娜",
                source = "WEB",
                centerImageUrl = "F:/Img/2w21g3iu5to812600.jpg"
            };
            fileUploadSdk.CreateQrCode(paramQrCode);


            /*删除文件*/
            fileUploadSdk.DelFiles("2006051414194142643EED0BF6D7EC4F");


            /*文件复制*/
            FileCopyRequest paramFileCopy = new FileCopyRequest()
            {
                tableBsId = 0,
                tableName = "",
                orgId = "1",
                description = "文件复制",
                orgName = "测试文件复制",
                source = "WEB",
                title = "无文件复制",
                userId = "11",
                userName = "adf"
            };
            fileUploadSdk.FileCopy(paramFileCopy);


            /*获取文件url*/
            fileUploadSdk.GetFileUrl("200605133956763767FDCCB903A2AE4D");


            /*保存网络资源url*/
            LinkUrlRequest paramSaveLinkUrl = new LinkUrlRequest()
            {
                description = "描述按实际对方立刻就哭了加速度开了房间奥斯卡代理费",
                fileName = "百度地图",
                fileTitle = "暂无标题",
                licId = "2",
                orgId = "2",
                orgName = "重庆旭永科技发展有限公司",
                source = "WEB",
                tableBsId = 2,
                tableName = "保存网络资源url",
                userId = "12",
                userName = "12312313"
            };
            fileUploadSdk.SaveLinkUrl(paramSaveLinkUrl);


            /*通用上传文件*/
            FileUploadRequest paramFileUpload = new FileUploadRequest()
            {
                description = "通用文件上传",
                fileName = "upload文件上传",
                filePath = "F:/Img/timg.jpg",
                licId = "3",
                operType = "add",
                orgId = "3",
                orgName = "123132",
                pathCustomDirName = "/125/upload",
                source = "WEB",
                tableBsId = 3,
                tableName = "通用文件上传",
                title = "无氨基酸的反馈",
                userId = "3",
                userName = "呵呵"
            };
            fileUploadSdk.Upload(paramFileUpload);


            /*base64上传文件*/
            FileUploadRequest paramFileUploadByBase64 = new FileUploadRequest()
            {
                description = "base64文件上传",
                fileName = "base64文件上传.png",
                fileBase64 = "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",
                licId = "4",
                operType = "add",
                orgId = "4",
                orgName = "123132",
                pathCustomDirName = "/125/upload",
                source = "WEB",
                tableBsId = 4,
                tableName = "通用文件上传",
                title = "无氨基酸的反馈",
                userId = "4",
                userName = "呵呵"
            };
            fileUploadSdk.Upload(paramFileUploadByBase64);


            /*文件流上传文件*/
            FileUploadRequest paramFileUploadByStream = new FileUploadRequest()
            {
                description = "文件流上传",
                filePath = @"F:\\Img\\74bf7e30d3d12610caae0fbb8758dafa.png",
                fileName = "74bf7e30d3d12610caae0fbb8758dafa.png",
                licId = "4",
                operType = "add",
                orgId = "4",
                orgName = "123132",
                pathCustomDirName = "/125/upload",
                source = "WEB",
                tableBsId = 4,
                tableName = "通用文件上传",
                title = "无氨基酸的反馈",
                userId = "4",
                userName = "呵呵"
            };
            fileUploadSdk.UploadStream(paramFileUploadByStream);
        }
    }
}

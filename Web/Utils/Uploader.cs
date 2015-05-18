using System;
using System.IO;
using System.Web;

namespace MVC5.Utils
{
    public class Uploader
    {
        /// <summary>
        /// Kiểm tra xem có upload file hay không
        /// </summary>
        /// <param name="FieldName">Tên trường file trên form</param>
        /// <returns>True nếu có upload, ngược lại thì không upload</returns>
        public static bool HasFile(String FieldName)
        {
            HttpPostedFile file = HttpContext.Current.Request.Files[FieldName];
            return (file != null && file.ContentLength > 0);
        }

        /// <summary>
        /// Lưu file upload
        /// </summary>
        /// <param name="FieldName">Tên trường file trên form</param>
        /// <param name="Folder">Thư mục lưu file upload</param>
        /// <param name="FileName">Tên file mới, nếu không truyền thì giữ nguyên tên của file upload</param>
        /// <returns>Tên file đã lưu</returns>
        public static String Save(String FieldName, String Folder, String FileName = null)
        {
            HttpPostedFile file = HttpContext.Current.Request.Files[FieldName];
            FileName = (FileName == null) ? file.FileName : FileName;
            String path = Path.Combine(Folder, FileName);
            file.SaveAs(HttpContext.Current.Server.MapPath(path));
            return FileName;
        }
    }
}
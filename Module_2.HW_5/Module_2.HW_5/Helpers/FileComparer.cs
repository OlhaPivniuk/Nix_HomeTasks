using System.Collections;

namespace Module_2.HW_5.Helpers
{
    public class FileComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var xFile = x as string;
            var yFile = y as string;

            if (xFile == null || yFile == null)
            {
                return 0;
            }

            FileInfo xFileInfo = new (xFile);
            FileInfo yFileInfo = new (yFile);

            return DateTime.Compare(xFileInfo.CreationTime, yFileInfo.CreationTime);
        }
    }
}

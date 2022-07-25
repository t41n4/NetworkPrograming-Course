using System.Collections.Generic;

namespace NT106.M21__Nhom09_55
{
    public class EmailListData
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public IEnumerable<MimeKit.MimeEntity> File { get; set; }
    }
}
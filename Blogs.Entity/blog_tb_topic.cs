//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blogs.Entity
{
    using FYJ;
    using System;
    using System.Collections.Generic;

    public partial class blog_tb_topic : FYJ.Entity.EntityBase
    {
        public int topicID { get; set; }
        public int blogID { get; set; }
        public string topicName { get; set; }
        public string topicDisplay { get; set; }
        public System.DateTime ADD_DATE { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }

        /// <summary>
        /// 文章数
        /// </summary>
        [Ignore]
        public int ArticleCount { get; set; }
    }
}

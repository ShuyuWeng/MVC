//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjMvcDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class tProduct
    {
        public int fId { get; set; }

        [Required(ErrorMessage = "產品名稱是必填欄位")]
        [DisplayName("產品名稱")]
        public string fName { get; set; }

        [Required(ErrorMessage = "進貨數量是必填欄位")]
        [DisplayName("進貨數量")]
        public Nullable<int> fQty { get; set; }

        [Required(ErrorMessage = "進貨價格是必填欄位")]
        [DisplayName("進貨價格")]
        public Nullable<decimal> fCost { get; set; }

        [Required(ErrorMessage = "銷售價格是必填欄位")]
        [DisplayName("銷售價格")]
        public Nullable<decimal> fPrice { get; set; }
        public string fImagePath { get; set; }
        public HttpPostedFileBase photo { get; set; }
    }
}

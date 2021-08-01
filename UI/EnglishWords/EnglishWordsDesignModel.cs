using OsnCsLib.WPFComponent.Bind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnglishWords.UI.EnglishWords {
    public class EnglishWordsDesignModel : EnglishWordsDataModel {

        #region Constructor
        public EnglishWordsDesignModel() {
            base.CurrentPage = 1;
            base.TotalPage = 1;
            base.PlayCount = 5;
        }
        #endregion

    }
}

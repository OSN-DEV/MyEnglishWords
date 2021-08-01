using OsnCsLib.WPFComponent.Bind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnglishWords.UI.EnglishWords {
    public class EnglishWordsDataModel : BaseBindable {

        #region Declaration
        #endregion

        #region Public Property
        /// <summary>
        /// 現在ページ
        /// </summary>
        private int _currentPage;
        public int CurrentPage {
            set {
                base.SetProperty(ref this._currentPage, value);
                base.SetProperty(nameof(PageInfo));
            }
            get { return this._currentPage; }
        }

        /// <summary>
        /// 総ページ
        /// </summary>
        private int _totalPage;
        public int TotalPage { 
            set {
                base.SetProperty(ref this._totalPage, value);
                base.SetProperty(nameof(PageInfo));
            }
            get { return this._totalPage; }
        }

        /// <summary>
        /// ページ情報
        /// </summary>
        public string PageInfo {
            get { return $"{this._currentPage.ToString("D3")}/{this._totalPage.ToString("D3")}"; }
        }

        /// <summary>
        /// 再生回数
        /// </summary>
        private int _playCount;
        public int PlayCount {
            set {
                base.SetProperty(ref this._playCount, value);
                base.SetProperty(nameof(DisplayPlayCount));
            }
            get { return this._playCount; }
        }

        /// <summary>
        /// 再生回数(表示用)
        /// </summary>
        public string DisplayPlayCount {
            get { return $"{this._playCount} times"; }
        }
        #endregion

        #region Constructor
        public EnglishWordsDataModel() {
            // 
        }
        #endregion
    }
}

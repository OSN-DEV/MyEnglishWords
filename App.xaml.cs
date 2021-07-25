using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyEnglishWords {
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application {

        #region Event
        protected override void OnStartup(StartupEventArgs e) {
            // 二重起動チェック
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e) {
            base.OnExit(e);
        }
        #endregion
    }
}

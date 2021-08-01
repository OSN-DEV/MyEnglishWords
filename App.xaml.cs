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

        #region Declaration
        private OsnCsLib.Common.AppLaunchChecker _checker = new OsnCsLib.Common.AppLaunchChecker("MyEnglishWords");
        #endregion

        #region Event
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            if (this._checker.IsLaunched()) {
                this.Shutdown();
            }
        }

        protected override void OnExit(ExitEventArgs e) {
            base.OnExit(e);
            this._checker.Release();
        }
        #endregion
    }
}

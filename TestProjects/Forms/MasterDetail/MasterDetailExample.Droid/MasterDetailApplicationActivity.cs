﻿using Android.App;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Droid;
using MvvmCross.Forms.Droid.Presenters;
using MvvmCross.Platform;
using Xamarin.Forms;

namespace MasterDetailExample.Droid
{
    [Activity(Label = "MasterDetailApplicationActivity", Icon="@android:color/transparent")]
    public class MasterDetailApplicationActivity : MvxFormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            var mvxFormsApp = new MvxFormsApplication();
            LoadApplication(mvxFormsApp);

            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsDroidMasterDetailPagePresenter;
            presenter.FormsApplication = mvxFormsApp;

            Mvx.Resolve<IMvxAppStart>().Start();
        }
    }
}
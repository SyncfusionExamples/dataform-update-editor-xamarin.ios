using CoreGraphics;
using Foundation;
using Syncfusion.iOS.DataForm;
using System;
using UIKit;

namespace DataFormXamariniOS
{
    public partial class ViewController : UIViewController
    {
        SfDataForm dataForm;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            UIStackView stack = new UIStackView();
            dataForm = new SfDataForm();
            dataForm.DataObject = new DataFormModel();
            dataForm.Frame = new CGRect(0, 100, 400, 1000);

            UIButton button = new UIButton();
            button.SetTitle("Submit", UIControlState.Normal);
            button.TouchUpInside += Button_TouchUpInside;
            button.Frame = new CGRect(0, 40, 400, 50);
            button.BackgroundColor = UIColor.Gray;
            stack.AddSubview(button);
            stack.AddSubview(dataForm);

            this.View.AddSubview(button);
            this.View.AddSubview(dataForm);
        }

        private void Button_TouchUpInside(object sender, EventArgs e)
        {
            var model = dataForm.DataObject as DataFormModel;
            model.Name = "John";
            dataForm.UpdateEditor("Name");
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
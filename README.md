# How to programmatically editing the DataForm in Xamarin.iOS (SfDataForm)

You can programmatically edit the [SfDataForm](https://help.syncfusion.com/cr/xamarin-ios/Syncfusion.SfDataForm.iOS.html?) using [UpdateEditor](https://help.syncfusion.com/cr/xamarin-ios/Syncfusion.SfDataForm.iOS~Syncfusion.iOS.DataForm.SfDataForm~UpdateEditor.html?) method in Xamarin.Forms.

You can also refer the following article.

https://www.syncfusion.com/kb/11457/how-to-programmatically-editing-the-dataform-in-xamarin-ios-sfdataform

**C#**

By using [DataObject](https://help.syncfusion.com/cr/xamarin-ios/Syncfusion.SfDataForm.iOS~Syncfusion.iOS.DataForm.SfDataForm~DataObject.html?) property you can get the input values of properties in DataForm. You can change the value and update the editor to refresh the editor with updated value.
``` c#
private void Button_TouchUpInside(object sender, EventArgs e)
        {
            var model = dataForm.DataObject as DataFormModel;
            model.Name = "John";
            dataForm.UpdateEditor("Name");
        }
```
**Output**

![DataFormUpdateEditor](https://github.com/SyncfusionExamples/dataform-update-editor-xamarin.ios/blob/master/ScreenShot/DataFormUpdateEditor.gif)

using System;
using System.Drawing;
using System.Windows.Forms;
using HBD.WinForms.UserControls;

namespace HBD.WinForms.Base
{
    internal interface IAddRemoveButton : IControl
    {
        Image AddImage { get; set; }
        int AddImageIndex { get; set; }
        string AddImageKey { get; set; }
        string AddText { get; set; }
        bool AutoEllipsis { get; set; }

        IListControlCollection ListControl { get; set; }
        FlatStyle FlatStyle { get; set; }
        ContentAlignment ImageAlign { get; set; }
        ImageList ImageList { get; set; }
        Image RemoveImage { get; set; }
        int RemoveImageIndex { get; set; }
        string RemoveImageKey { get; set; }
        string RemoveText { get; set; }
        ContentAlignment TextAlign { get; set; }
        TextImageRelation TextImageRelation { get; set; }

        event EventHandler<AddRemoveButtonEventArgs> Click;
    }
}
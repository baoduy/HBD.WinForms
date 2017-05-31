using System;

namespace HBD.WinForms.Attributes
{
    /// <summary>
    ///     Add this attribute to your Control so the extension properties of ValidationManageer won't be displayed on the
    ///     PropertyBox.
    /// </summary>
    public class NotAllowValidationAttribute : Attribute
    {
    }
}
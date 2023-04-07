using Microsoft.AspNetCore.Mvc;

namespace wiutLMS.ViewModels
{
    public class ConfirmOperationViewModel
    {
        [HiddenInput] public bool Sure { get; set; } = true;
        [HiddenInput] public int Id { get; set; }
    }
}
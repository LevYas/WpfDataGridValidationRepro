using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace WpfDataGridValidationRepro
{
    public class MainWindowVm
    {
        public ObservableCollection<ItemVm> Items { get; } = new()
        {
            new ItemVm(),
            new ItemVm(),
            new ItemVm(),
        };
    }

    public class ItemVm : IDataErrorInfo
    {
        public string PostalCode { get; set; } = "123";

        public string Error => "";

        public string? this[string name] =>
            name switch
            {
                nameof(PostalCode) => validatePostalCode(PostalCode),
                _ => null,
            };

        private static string? validatePostalCode(string code)
        {
            return code.All(c => Char.IsDigit(c) || c == '-')
                       ? null
                       : "Please use digits only";
        }
    }
}

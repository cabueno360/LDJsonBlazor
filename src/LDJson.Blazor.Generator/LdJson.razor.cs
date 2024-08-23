using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using static Functional.DotNet.F;

namespace LDJson.Blazor.Generator
{
    public partial class LdJson : INotifyPropertyChanged
    {
        [Parameter]
        public LdJsonModel Data { get; set; } = LdJsonModel.None;


        private MarkupString ldJsonMarkup;

      

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public static class LDJsonExt2 
    {
        public static MarkupString ToMakupString(this LdJsonModel ldJson) 
        {
            
            string result = $"<script type=\"application/ld+json\">{ldJson.ToLDJson()}</script>";
            return  new MarkupString(result);
        }

        public static MarkupString ToMakupString(this string value) => new MarkupString(value);
        
    }
}

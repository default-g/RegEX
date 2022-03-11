using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using System.Text.RegularExpressions;


namespace RegEX.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string input = "";
        string output = "";
        string regex = "";
        public MainWindowViewModel()
        {
       
        }
        public string Input
        {
            set
            {
                this.RaiseAndSetIfChanged(ref input, value);
                Output = this.Input;
            }
            get
            {
                return this.input;
            }
        }
        public string Output
        {
            set
            {
                this.RaiseAndSetIfChanged(ref output, value);
            }
            get
            {
                return this.output;
            }
        }
        public void ChangeOutput()
        {
            this.output = this.input;


        }
    
    }
 
}

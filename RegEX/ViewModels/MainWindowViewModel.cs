using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using System.Text.RegularExpressions;
using Avalonia.Controls;
using RegEX.Models;

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

        public void SaveOutputInFile(string path)
        {
            var fileIO = new FileConroller();
            fileIO.Write(this.Output, path);
        }

        public void ReadFileToInput(string path)
        {
            var fileIO = new FileConroller();
            this.Input = fileIO.Read(path);
        }
    
    }
 
}

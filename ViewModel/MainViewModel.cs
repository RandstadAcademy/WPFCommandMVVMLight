using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
  public class MainViewModel
  {
    public MyCommand TestCommand { get; set; }
    public MyCommand EnableCommand { get; set; }

    private bool testEnabled = false;

    public MainViewModel()
    {
      TestCommand = new MyCommand(TestCommanExecute, () => { return TestCommandCanExecute(); });
      EnableCommand = new MyCommand(EnableCommandExecute);
    }

  protected void TestCommanExecute()
    {
      // DO something

    }

    protected bool TestCommandCanExecute()
    {
      return testEnabled;
    }

    protected void EnableCommandExecute()
    {
      testEnabled = true;
      
    }

  }
}

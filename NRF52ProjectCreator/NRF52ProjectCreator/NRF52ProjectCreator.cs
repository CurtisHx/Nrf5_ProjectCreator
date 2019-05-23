using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRF52ProjectCreator
{
  public partial class NRF52ProjectCreator : Form
  {
    public NRF52ProjectCreator()
    {
      InitializeComponent();
    }

    private string destinationFolder;
    private string examplePath;
    private string projectName;

    #region UI Update
    private void UpdateDestinationFolderText()
    {
      if (tbxDestitnationFolder.InvokeRequired)
      {
        tbxDestitnationFolder.BeginInvoke(new Action(UpdateDestinationFolderText));
        return;
      }
      tbxDestitnationFolder.Text = destinationFolder;
    }

    private void UpdateSamplePathText()
    {
      if (tbxExamplePath.InvokeRequired)
      {
        tbxExamplePath.BeginInvoke(new Action(UpdateSamplePathText));
        return;
      }
      tbxExamplePath.Text = projectName;
    }

    private void UpdateProjectNameText()
    {
      if(tbxProjectName.InvokeRequired)
      {
        tbxProjectName.BeginInvoke(new Action(UpdateProjectNameText));
        return;
      }
      tbxProjectName.Text = projectName;
    }

    private void UpdateTextBoxes()
    {
      UpdateDestinationFolderText();
      UpdateSamplePathText();
      UpdateProjectNameText();
    }
    #endregion

    private void btnExampleBrowse_Click(object sender, EventArgs e)
    {
      try
      {
        OpenFileDialog open = new OpenFileDialog();
        //\"Text files (*.txt)|*.txt|All files (*.*)|*.*\"
        open.Filter = "Segger Project (*.emProject)|*.emProject";
        open.Multiselect = false;
        if (open.ShowDialog() == DialogResult.OK)
        {
          examplePath = open.FileName;
        }
        UpdateTextBoxes();
      }
      catch (Exception ex)
      {
        LogError("Something went wrong in {0}. {1}", nameof(btnExampleBrowse_Click), ex.ToString());
      }
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
      try
      {

      }
      catch (Exception ex)
      {
        LogError("Something went wrong in {0}. {1}", nameof(btnGenerate_Click), ex.ToString());
      }
    }

    private void tbxProjectName_TextChanged(object sender, EventArgs e)
    {
      projectName = tbxProjectName.Text;
    }

    private void tbxExamplePath_TextChanged(object sender, EventArgs e)
    {
      examplePath = tbxExamplePath.Text;
    }

    private void tbxDestitnationFolder_TextChanged(object sender, EventArgs e)
    {
      destinationFolder = tbxDestitnationFolder.Text;
    }

    #region Validation

    private void ValidateAll()
    {

    }

    private void ValidateExamplePath()
    {

    }

    private void ValidateDestinationFolder()
    {

    }

    #endregion

    #region Logging
    private void LogError(string message)
    {
      if (rtbOutput.InvokeRequired)
      {
        rtbOutput.BeginInvoke(new Action<string>(LogError), message);
        return;
      }
      string text = string.Concat(String.Format("{0}{1}: {2}", Environment.NewLine, DateTime.Now.ToString("HH:mm:ss"), message));
      rtbOutput.AppendText(text, Color.Red);
    }

    private void LogError(string format, params object[] args)
    {
      LogError(string.Format(format, args));
    }

    private void LogMessage(string message)
    {
      if (rtbOutput.InvokeRequired)
      {
        rtbOutput.BeginInvoke(new Action<string>(LogError), message);
        return;
      }
      string text = string.Concat(String.Format("{0}{1}: {2}", Environment.NewLine, DateTime.Now.ToString("HH:mm:ss"), message));
      rtbOutput.AppendText(text);
    }

    private void LogMessage(string message, params object[] args)
    {
      LogMessage(String.Format(message, args));
    }
    #endregion
  }

  public static class RichTextBoxExtensions
  {
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
      box.SelectionStart = box.TextLength;
      box.SelectionLength = 0;

      box.SelectionColor = color;
      box.AppendText(text);
      box.SelectionColor = box.ForeColor;
      box.SelectionStart = box.TextLength;
    }

    public static void AppendText(this RichTextBox box, string text)
    {
      box.SelectionStart = box.TextLength;
      box.SelectionLength = 0;

      box.AppendText(text);

      box.SelectionStart = box.TextLength;
    }
  }
}

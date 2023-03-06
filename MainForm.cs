

#region using statements

using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Enumerations;
using DataJuggler.UltimateHelper.Objects;

#endregion

namespace CodopyDesktop
{

    #region class MainForm
    /// <summary>
    /// This class [Enter Class Description]
    /// </summary>
    public partial class MainForm : Form
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events

        #region CopyButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'CopyButton' is clicked.
        /// </summary>
        private void CopyButton_Click(object sender, EventArgs e)
        {
            // Copy to your clipboard
            Clipboard.SetText(ResultsControl.Text);
        }
        #endregion

        #region FormatButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'FormatButton' is clicked.
        /// </summary>
        private void FormatButton_Click(object sender, EventArgs e)
        {
            // Get the text
            string text = SourceControl.Text;

            // Format the code
            string results = CodeHelper.FormatCode(text, LanguageEnum.CSharp);

            // Set the results
            ResultsControl.Text = results;
        }
        #endregion

        #endregion

    }
    #endregion

}

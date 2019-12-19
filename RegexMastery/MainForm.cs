using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.ModifyRegistry;

namespace RegexMastery {
	public partial class MainForm : Form {

		public MainForm() {
			InitializeComponent();
		}

		private void Exit_Click(object sender, EventArgs e) {
			Serialize(); 
			Close();
		}

		private void Form_Show(object sender, EventArgs e) {
			LoadSerialization();
		}

		private void Form_Close(object sender, FormClosedEventArgs e) {
			Serialize();
		}

		private void FormControl_Change(object sender, EventArgs e) {
			Evaluate();
		}

		protected void Evaluate() {
			string output = "";
			string input = InputString.Text;
			string pattern = RegexString.Text;
			string replace = ReplaceString.Text;

			try {
				if (input != "" && pattern != "") {
					Regex reg = new Regex(pattern, 
						(IgnoreCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None) |
						(SingleLine.Checked ? RegexOptions.Singleline : RegexOptions.None) |
						(MultiLine.Checked ? RegexOptions.Multiline : RegexOptions.None)
						);

					if (Replace.Checked) {
						output = reg.Replace(input, replace);
					}
					else {
						int matchCount = 0;
						MatchCollection matches = reg.Matches(input);
						foreach (Match match in matches) {
							output += string.Format("Regex.Matches[{0}] = {1}\r\n", matchCount, match.ToString() ?? "<null>");

							int groupCount = 0;
							GroupCollection groups = match.Groups;
							foreach (Group group in groups) {
								output += string.Format("     .Matches[{0}].Groups[{1}] = {2}\r\n", matchCount, groupCount++, group.ToString() ?? "<null>");
							}

							if (groupCount == 0) {
								output += string.Format("     .Matches[{0}].Groups.Count = 0\r\n", matchCount);
							}

							output += "\r\n";
							matchCount++;
						}

						if (matchCount == 0)
							output += string.Format("Regex.Matches.Count = 0");
					}
				}
				else
					output = "Nothing to evaluate.";
			}
			catch (Exception e) {
				output = "Exception Caught:\r\n";
				while (e != null) {
					output += e.Message + "\r\n";
					e = e.InnerException;
				}
			}

			OutputString.Text = output;
		}

		protected void Serialize() {
			try {
				ModifyRegistry reg = new ModifyRegistry();

				reg.Write("Pattern", RegexString.Text);
				reg.Write("Input", InputString.Text);
				reg.Write("Replace", ReplaceString.Text);

				reg.Write("IgnoreCase", IgnoreCase.Checked);
				reg.Write("SingleLine", SingleLine.Checked);
				reg.Write("MultiLine", MultiLine.Checked);
				reg.Write("ReplaceOn", Replace.Checked);
			}
			catch (Exception ex) {
				MessageBox.Show("Error Saving Form to Registry", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		protected void LoadSerialization() {
			try {
				ModifyRegistry reg = new ModifyRegistry();

				RegexString.Text = reg.Read("Pattern") ?? "";
				InputString.Text = reg.Read("Input") ?? "";
				ReplaceString.Text = reg.Read("Replace") ?? "";

				IgnoreCase.Checked = (reg.Read("IgnoreCase") ?? "") == "True" ? true : false;
				SingleLine.Checked = (reg.Read("SingleLine") ?? "") == "True" ? true : false;
				MultiLine.Checked = (reg.Read("MultiLine") ?? "") == "True" ? true : false;
				Replace.Checked = (reg.Read("ReplaceOn") ?? "") == "True" ? true : false;
			}
			catch (Exception ex) {
				MessageBox.Show("Error Loading Form from Registry", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

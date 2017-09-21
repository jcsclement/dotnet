namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openXMLFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnConvert2Json = new System.Windows.Forms.Button();
            this.textJsonBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textXMLBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openXMLFileDialog
            // 
            this.openXMLFileDialog.FileName = "openXMLFile";
            this.openXMLFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnConvert2Json
            // 
            this.btnConvert2Json.Location = new System.Drawing.Point(12, 12);
            this.btnConvert2Json.Name = "btnConvert2Json";
            this.btnConvert2Json.Size = new System.Drawing.Size(150, 23);
            this.btnConvert2Json.TabIndex = 0;
            this.btnConvert2Json.Text = "Convert xml to json";
            this.btnConvert2Json.UseVisualStyleBackColor = true;
            this.btnConvert2Json.Click += new System.EventHandler(this.button1_Click);
            // 
            // textJsonBox
            // 
            this.textJsonBox.Location = new System.Drawing.Point(450, 71);
            this.textJsonBox.Multiline = true;
            this.textJsonBox.Name = "textJsonBox";
            this.textJsonBox.Size = new System.Drawing.Size(372, 251);
            this.textJsonBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "JSON text area";
            // 
            // textXMLBox
            // 
            this.textXMLBox.Location = new System.Drawing.Point(12, 71);
            this.textXMLBox.Multiline = true;
            this.textXMLBox.Name = "textXMLBox";
            this.textXMLBox.Size = new System.Drawing.Size(372, 251);
            this.textXMLBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "XML text area";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(745, 12);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(29, 13);
            this.lblRuntime.TabIndex = 5;
            this.lblRuntime.Text = "0 ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Runtime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textXMLBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textJsonBox);
            this.Controls.Add(this.btnConvert2Json);
            this.Name = "Form1";
            this.Text = "Parsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openXMLFileDialog;
        private System.Windows.Forms.Button btnConvert2Json;
        private System.Windows.Forms.TextBox textJsonBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textXMLBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label label3;
    }
}


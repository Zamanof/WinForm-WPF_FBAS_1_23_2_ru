namespace WF_WPF_03._TreeView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode6 = new TreeNode("Child1");
            TreeNode treeNode7 = new TreeNode("Child2");
            TreeNode treeNode8 = new TreeNode("Root1", new TreeNode[] { treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Child3");
            TreeNode treeNode10 = new TreeNode("Root2", new TreeNode[] { treeNode9 });
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.HideSelection = false;
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Child1";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Child2";
            treeNode8.Checked = true;
            treeNode8.Name = "Node0";
            treeNode8.Text = "Root1";
            treeNode9.Name = "Node4";
            treeNode9.Text = "Child3";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Root2";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode8, treeNode10 });
            treeView1.Size = new Size(189, 97);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
    }
}
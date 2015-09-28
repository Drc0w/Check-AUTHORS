namespace CheckAuthors
{
    partial class CheckAuthorsForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAuthorsForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadListButton = new System.Windows.Forms.Button();
            this.loadDirectoriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Login});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Login
            // 
            resources.ApplyResources(this.Login, "Login");
            // 
            // loadListButton
            // 
            resources.ApplyResources(this.loadListButton, "loadListButton");
            this.loadListButton.Name = "loadListButton";
            this.loadListButton.UseVisualStyleBackColor = true;
            this.loadListButton.Click += new System.EventHandler(this.loadListButton_Click);
            // 
            // loadDirectoriesButton
            // 
            resources.ApplyResources(this.loadDirectoriesButton, "loadDirectoriesButton");
            this.loadDirectoriesButton.Name = "loadDirectoriesButton";
            this.loadDirectoriesButton.UseVisualStyleBackColor = true;
            this.loadDirectoriesButton.Click += new System.EventHandler(this.loadDirectoriesButton_Click);
            // 
            // CheckAuthorsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadDirectoriesButton);
            this.Controls.Add(this.loadListButton);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "CheckAuthorsForm";
            this.Load += new System.EventHandler(this.CheckAuthorsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button loadListButton;
        private System.Windows.Forms.Button loadDirectoriesButton;
        private System.Windows.Forms.ColumnHeader Login;
    }
}


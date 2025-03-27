namespace Ejercicio_sobre_listas
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
            label1 = new Label();
            label2 = new Label();
            lbSinOrdenar = new ListBox();
            lbordenada = new ListBox();
            btntoleft = new Button();
            btntoright = new Button();
            btnborrarlistaright = new Button();
            btnborrarright = new Button();
            btnagregarright = new Button();
            btnborrarlistaleft = new Button();
            btnborrarleft = new Button();
            btnagregarleft = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(263, 41);
            label1.TabIndex = 0;
            label1.Text = "Lista sin Ordenar ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(450, 25);
            label2.Name = "label2";
            label2.Size = new Size(238, 41);
            label2.TabIndex = 1;
            label2.Text = "Lista Ordenada ";
            // 
            // lbSinOrdenar
            // 
            lbSinOrdenar.FormattingEnabled = true;
            lbSinOrdenar.ItemHeight = 20;
            lbSinOrdenar.Location = new Point(90, 87);
            lbSinOrdenar.Name = "lbSinOrdenar";
            lbSinOrdenar.Size = new Size(150, 264);
            lbSinOrdenar.TabIndex = 2;
            lbSinOrdenar.SelectedIndexChanged += txtLBSinOrdenar_SelectedIndexChanged;
            // 
            // lbordenada
            // 
            lbordenada.FormattingEnabled = true;
            lbordenada.ItemHeight = 20;
            lbordenada.Location = new Point(506, 87);
            lbordenada.Name = "lbordenada";
            lbordenada.Size = new Size(150, 264);
            lbordenada.Sorted = true;
            lbordenada.TabIndex = 3;
            // 
            // btntoleft
            // 
            btntoleft.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btntoleft.Location = new Point(326, 122);
            btntoleft.Name = "btntoleft";
            btntoleft.Size = new Size(105, 70);
            btntoleft.TabIndex = 4;
            btntoleft.Text = "<<";
            btntoleft.UseVisualStyleBackColor = true;
            btntoleft.Click += btntoleft_Click;
            // 
            // btntoright
            // 
            btntoright.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btntoright.Location = new Point(326, 245);
            btntoright.Name = "btntoright";
            btntoright.Size = new Size(105, 72);
            btntoright.TabIndex = 5;
            btntoright.Text = ">>";
            btntoright.UseVisualStyleBackColor = true;
            btntoright.Click += btntoright_Click;
            // 
            // btnborrarlistaright
            // 
            btnborrarlistaright.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnborrarlistaright.Location = new Point(506, 462);
            btnborrarlistaright.Name = "btnborrarlistaright";
            btnborrarlistaright.Size = new Size(150, 29);
            btnborrarlistaright.TabIndex = 6;
            btnborrarlistaright.Text = "Borrar lista";
            btnborrarlistaright.UseVisualStyleBackColor = true;
            btnborrarlistaright.Click += btnborrarlistaright_Click;
            // 
            // btnborrarright
            // 
            btnborrarright.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnborrarright.Location = new Point(506, 417);
            btnborrarright.Name = "btnborrarright";
            btnborrarright.Size = new Size(150, 29);
            btnborrarright.TabIndex = 7;
            btnborrarright.Text = "Borrar elemento";
            btnborrarright.UseVisualStyleBackColor = true;
            btnborrarright.Click += btnborrarright_Click;
            // 
            // btnagregarright
            // 
            btnagregarright.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregarright.Location = new Point(506, 371);
            btnagregarright.Name = "btnagregarright";
            btnagregarright.Size = new Size(150, 29);
            btnagregarright.TabIndex = 8;
            btnagregarright.Text = "Añadir elemento ";
            btnagregarright.UseVisualStyleBackColor = true;
            btnagregarright.Click += btnagregarright_Click;
            // 
            // btnborrarlistaleft
            // 
            btnborrarlistaleft.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnborrarlistaleft.Location = new Point(90, 462);
            btnborrarlistaleft.Name = "btnborrarlistaleft";
            btnborrarlistaleft.Size = new Size(143, 29);
            btnborrarlistaleft.TabIndex = 9;
            btnborrarlistaleft.Text = "Borrar lista";
            btnborrarlistaleft.UseVisualStyleBackColor = true;
            btnborrarlistaleft.Click += btnborrarlistaleft_Click;
            // 
            // btnborrarleft
            // 
            btnborrarleft.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnborrarleft.Location = new Point(90, 417);
            btnborrarleft.Name = "btnborrarleft";
            btnborrarleft.Size = new Size(143, 29);
            btnborrarleft.TabIndex = 10;
            btnborrarleft.Text = "Borrar elemento ";
            btnborrarleft.UseVisualStyleBackColor = true;
            btnborrarleft.Click += btnborrarleft_Click;
            // 
            // btnagregarleft
            // 
            btnagregarleft.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregarleft.Location = new Point(90, 371);
            btnagregarleft.Name = "btnagregarleft";
            btnagregarleft.Size = new Size(143, 29);
            btnagregarleft.TabIndex = 11;
            btnagregarleft.Text = "Añadir elemento";
            btnagregarleft.UseVisualStyleBackColor = true;
            btnagregarleft.Click += btnagregarleft_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 528);
            Controls.Add(btnagregarleft);
            Controls.Add(btnborrarleft);
            Controls.Add(btnborrarlistaleft);
            Controls.Add(btnagregarright);
            Controls.Add(btnborrarright);
            Controls.Add(btnborrarlistaright);
            Controls.Add(btntoright);
            Controls.Add(btntoleft);
            Controls.Add(lbordenada);
            Controls.Add(lbSinOrdenar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lbSinOrdenar;
        private ListBox lbordenada;
        private Button btntoleft;
        private Button btntoright;
        private Button btnborrarlistaright;
        private Button btnborrarright;
        private Button btnagregarright;
        private Button btnborrarlistaleft;
        private Button btnborrarleft;
        private Button btnagregarleft;
    }
}
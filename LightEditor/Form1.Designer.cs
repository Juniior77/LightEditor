namespace LightEditor
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_id = new System.Windows.Forms.Label();
            this.label_marque = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_lamp_type = new System.Windows.Forms.Label();
            this.label_lamp_power = new System.Windows.Forms.Label();
            this.label_beam = new System.Windows.Forms.Label();
            this.label_beam_angle = new System.Windows.Forms.Label();
            this.label_pan_angle = new System.Windows.Forms.Label();
            this.label_pan_speed = new System.Windows.Forms.Label();
            this.label_tilt_angle = new System.Windows.Forms.Label();
            this.label_tilt_speed = new System.Windows.Forms.Label();
            this.panel_fixture = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_undef = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.button_gobo = new System.Windows.Forms.Button();
            this.button_pan_tilt = new System.Windows.Forms.Button();
            this.button_dimmer = new System.Windows.Forms.Button();
            this.button_cym = new System.Windows.Forms.Button();
            this.button_rgb = new System.Windows.Forms.Button();
            this.None_label_channel = new System.Windows.Forms.Label();
            this.panel_UserControl = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_UserControl, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 681);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_fixture, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(319, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(626, 675);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label_id, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_marque, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_version, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_type, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_lamp_type, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_lamp_power, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_beam, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_beam_angle, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_pan_angle, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label_pan_speed, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label_tilt_angle, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label_tilt_speed, 3, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(620, 95);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label_id
            // 
            this.label_id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(10, 9);
            this.label_id.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID:";
            // 
            // label_marque
            // 
            this.label_marque.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_marque.AutoSize = true;
            this.label_marque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_marque.Location = new System.Drawing.Point(165, 9);
            this.label_marque.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_marque.Name = "label_marque";
            this.label_marque.Size = new System.Drawing.Size(53, 13);
            this.label_marque.TabIndex = 1;
            this.label_marque.Text = "Marque:";
            // 
            // label_version
            // 
            this.label_version.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.Location = new System.Drawing.Point(320, 9);
            this.label_version.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(53, 13);
            this.label_version.TabIndex = 2;
            this.label_version.Text = "Version:";
            // 
            // label_type
            // 
            this.label_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Location = new System.Drawing.Point(475, 9);
            this.label_type.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(39, 13);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "Type:";
            // 
            // label_lamp_type
            // 
            this.label_lamp_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_lamp_type.AutoSize = true;
            this.label_lamp_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lamp_type.Location = new System.Drawing.Point(10, 40);
            this.label_lamp_type.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_lamp_type.Name = "label_lamp_type";
            this.label_lamp_type.Size = new System.Drawing.Size(68, 13);
            this.label_lamp_type.TabIndex = 4;
            this.label_lamp_type.Text = "Lampe (T):";
            // 
            // label_lamp_power
            // 
            this.label_lamp_power.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_lamp_power.AutoSize = true;
            this.label_lamp_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lamp_power.Location = new System.Drawing.Point(165, 40);
            this.label_lamp_power.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_lamp_power.Name = "label_lamp_power";
            this.label_lamp_power.Size = new System.Drawing.Size(72, 13);
            this.label_lamp_power.TabIndex = 5;
            this.label_lamp_power.Text = "Lampe (W):";
            // 
            // label_beam
            // 
            this.label_beam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_beam.AutoSize = true;
            this.label_beam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_beam.Location = new System.Drawing.Point(320, 40);
            this.label_beam.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_beam.Name = "label_beam";
            this.label_beam.Size = new System.Drawing.Size(42, 13);
            this.label_beam.TabIndex = 6;
            this.label_beam.Text = "Beam:";
            // 
            // label_beam_angle
            // 
            this.label_beam_angle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_beam_angle.AutoSize = true;
            this.label_beam_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_beam_angle.Location = new System.Drawing.Point(475, 40);
            this.label_beam_angle.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_beam_angle.Name = "label_beam_angle";
            this.label_beam_angle.Size = new System.Drawing.Size(77, 13);
            this.label_beam_angle.TabIndex = 7;
            this.label_beam_angle.Text = "Beam angle:";
            // 
            // label_pan_angle
            // 
            this.label_pan_angle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_pan_angle.AutoSize = true;
            this.label_pan_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pan_angle.Location = new System.Drawing.Point(10, 72);
            this.label_pan_angle.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_pan_angle.Name = "label_pan_angle";
            this.label_pan_angle.Size = new System.Drawing.Size(71, 13);
            this.label_pan_angle.TabIndex = 8;
            this.label_pan_angle.Text = "PAN angle:";
            // 
            // label_pan_speed
            // 
            this.label_pan_speed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_pan_speed.AutoSize = true;
            this.label_pan_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pan_speed.Location = new System.Drawing.Point(165, 72);
            this.label_pan_speed.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_pan_speed.Name = "label_pan_speed";
            this.label_pan_speed.Size = new System.Drawing.Size(74, 13);
            this.label_pan_speed.TabIndex = 9;
            this.label_pan_speed.Text = "PAN speed:";
            // 
            // label_tilt_angle
            // 
            this.label_tilt_angle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_tilt_angle.AutoSize = true;
            this.label_tilt_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tilt_angle.Location = new System.Drawing.Point(320, 72);
            this.label_tilt_angle.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_tilt_angle.Name = "label_tilt_angle";
            this.label_tilt_angle.Size = new System.Drawing.Size(73, 13);
            this.label_tilt_angle.TabIndex = 10;
            this.label_tilt_angle.Text = "TILT angle:";
            // 
            // label_tilt_speed
            // 
            this.label_tilt_speed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_tilt_speed.AutoSize = true;
            this.label_tilt_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tilt_speed.Location = new System.Drawing.Point(475, 72);
            this.label_tilt_speed.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_tilt_speed.Name = "label_tilt_speed";
            this.label_tilt_speed.Size = new System.Drawing.Size(76, 13);
            this.label_tilt_speed.TabIndex = 11;
            this.label_tilt_speed.Text = "TILT speed:";
            // 
            // panel_fixture
            // 
            this.panel_fixture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fixture.Location = new System.Drawing.Point(3, 104);
            this.panel_fixture.Name = "panel_fixture";
            this.panel_fixture.Size = new System.Drawing.Size(620, 568);
            this.panel_fixture.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_undef);
            this.panel1.Controls.Add(this.button_color);
            this.panel1.Controls.Add(this.button_gobo);
            this.panel1.Controls.Add(this.button_pan_tilt);
            this.panel1.Controls.Add(this.button_dimmer);
            this.panel1.Controls.Add(this.button_cym);
            this.panel1.Controls.Add(this.button_rgb);
            this.panel1.Controls.Add(this.None_label_channel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 675);
            this.panel1.TabIndex = 1;
            // 
            // button_undef
            // 
            this.button_undef.Location = new System.Drawing.Point(157, 129);
            this.button_undef.Name = "button_undef";
            this.button_undef.Size = new System.Drawing.Size(65, 65);
            this.button_undef.TabIndex = 7;
            this.button_undef.Text = "Undeff";
            this.button_undef.UseVisualStyleBackColor = true;
            this.button_undef.Click += new System.EventHandler(this.button_undef_Click);
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(86, 129);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(65, 65);
            this.button_color.TabIndex = 6;
            this.button_color.Text = "Color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button_gobo
            // 
            this.button_gobo.Location = new System.Drawing.Point(15, 129);
            this.button_gobo.Name = "button_gobo";
            this.button_gobo.Size = new System.Drawing.Size(65, 65);
            this.button_gobo.TabIndex = 5;
            this.button_gobo.Text = "Gobo";
            this.button_gobo.UseVisualStyleBackColor = true;
            this.button_gobo.Click += new System.EventHandler(this.button_gobo_Click);
            // 
            // button_pan_tilt
            // 
            this.button_pan_tilt.Location = new System.Drawing.Point(228, 58);
            this.button_pan_tilt.Name = "button_pan_tilt";
            this.button_pan_tilt.Size = new System.Drawing.Size(65, 65);
            this.button_pan_tilt.TabIndex = 4;
            this.button_pan_tilt.Text = "PAN &  TILT";
            this.button_pan_tilt.UseVisualStyleBackColor = true;
            this.button_pan_tilt.Click += new System.EventHandler(this.button_pan_tilt_Click);
            // 
            // button_dimmer
            // 
            this.button_dimmer.Location = new System.Drawing.Point(157, 58);
            this.button_dimmer.Name = "button_dimmer";
            this.button_dimmer.Size = new System.Drawing.Size(65, 65);
            this.button_dimmer.TabIndex = 3;
            this.button_dimmer.Text = "Dimmer";
            this.button_dimmer.UseVisualStyleBackColor = true;
            this.button_dimmer.Click += new System.EventHandler(this.button_dimmer_Click);
            // 
            // button_cym
            // 
            this.button_cym.Location = new System.Drawing.Point(86, 58);
            this.button_cym.Name = "button_cym";
            this.button_cym.Size = new System.Drawing.Size(65, 65);
            this.button_cym.TabIndex = 2;
            this.button_cym.Text = "CYM";
            this.button_cym.UseVisualStyleBackColor = true;
            this.button_cym.Click += new System.EventHandler(this.button_cym_Click);
            // 
            // button_rgb
            // 
            this.button_rgb.Location = new System.Drawing.Point(15, 58);
            this.button_rgb.Name = "button_rgb";
            this.button_rgb.Size = new System.Drawing.Size(65, 65);
            this.button_rgb.TabIndex = 1;
            this.button_rgb.Text = "RGB";
            this.button_rgb.UseVisualStyleBackColor = true;
            this.button_rgb.Click += new System.EventHandler(this.button_rgb_Click);
            // 
            // None_label_channel
            // 
            this.None_label_channel.AutoSize = true;
            this.None_label_channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.None_label_channel.Location = new System.Drawing.Point(115, 12);
            this.None_label_channel.Name = "None_label_channel";
            this.None_label_channel.Size = new System.Drawing.Size(75, 20);
            this.None_label_channel.TabIndex = 0;
            this.None_label_channel.Text = "Channel";
            // 
            // panel_UserControl
            // 
            this.panel_UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_UserControl.Location = new System.Drawing.Point(951, 3);
            this.panel_UserControl.Name = "panel_UserControl";
            this.panel_UserControl.Size = new System.Drawing.Size(310, 675);
            this.panel_UserControl.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_marque;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_lamp_type;
        private System.Windows.Forms.Label label_lamp_power;
        private System.Windows.Forms.Label label_beam;
        private System.Windows.Forms.Label label_beam_angle;
        private System.Windows.Forms.Label label_pan_angle;
        private System.Windows.Forms.Label label_pan_speed;
        private System.Windows.Forms.Label label_tilt_angle;
        private System.Windows.Forms.Label label_tilt_speed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_undef;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Button button_gobo;
        private System.Windows.Forms.Button button_pan_tilt;
        private System.Windows.Forms.Button button_dimmer;
        private System.Windows.Forms.Button button_cym;
        private System.Windows.Forms.Button button_rgb;
        private System.Windows.Forms.Label None_label_channel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel_UserControl;
        private System.Windows.Forms.Panel panel_fixture;
    }
}


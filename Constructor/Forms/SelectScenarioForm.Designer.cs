namespace Constructor
{
    partial class SelectScenarioForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.scenarioControl6 = new Constructor.ScenarioControl();
            this.scenarioControl7 = new Constructor.ScenarioControl();
            this.scenarioControl8 = new Constructor.ScenarioControl();
            this.scenarioControl1 = new Constructor.ScenarioControl();
            this.scenarioControl2 = new Constructor.ScenarioControl();
            this.scenarioControl3 = new Constructor.ScenarioControl();
            this.scenarioControl4 = new Constructor.ScenarioControl();
            this.scenarioControl5 = new Constructor.ScenarioControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор сценария";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Обучение с использованием ваших данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1012, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "В следующих сценариях для обучения и выбора наилучшей модели для ваших данных исп" +
    "ользуется Автоматизированное машинное обучение.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.linkLabel1.Location = new System.Drawing.Point(13, 115);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(541, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Дополнительные сведения об обучении с собственными данными в Model Builder.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.scenarioControl1);
            this.flowLayoutPanel1.Controls.Add(this.scenarioControl2);
            this.flowLayoutPanel1.Controls.Add(this.scenarioControl3);
            this.flowLayoutPanel1.Controls.Add(this.scenarioControl4);
            this.flowLayoutPanel1.Controls.Add(this.scenarioControl5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 155);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1008, 670);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.linkLabel2.Location = new System.Drawing.Point(13, 915);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(363, 17);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Дополнительные сведения о примерах в Model Builder.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 885);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1493, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Следующие сценарии еще не поддерживаются в Автоматизированном машинном обучении, " +
    "поэтому для них предоставляются пошаговые инструкиции с примерами наборов данных" +
    " и заданным кодом обучения.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 845);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ограниченные сценарии";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.scenarioControl6);
            this.flowLayoutPanel2.Controls.Add(this.scenarioControl7);
            this.flowLayoutPanel2.Controls.Add(this.scenarioControl8);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(20, 965);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1008, 338);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // scenarioControl6
            // 
            this.scenarioControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.scenarioControl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scenarioControl6.Location = new System.Drawing.Point(3, 3);
            this.scenarioControl6.Margin = new System.Windows.Forms.Padding(3, 3, 27, 27);
            this.scenarioControl6.MaximumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl6.MinimumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl6.Name = "scenarioControl6";
            this.scenarioControl6.ScenarioDescription = "Обнаружение аномалий или выбросов в данных. Этот пример обнаруживает пики в данны" +
    "х о продаже шампуня.";
            this.scenarioControl6.ScenarioImage = global::Constructor.Properties.Resources.обнаружение_аномалий;
            this.scenarioControl6.ScenarioName = "Обнаружение аномалий (недоступно)";
            this.scenarioControl6.Size = new System.Drawing.Size(220, 300);
            this.scenarioControl6.TabIndex = 4;
            // 
            // scenarioControl7
            // 
            this.scenarioControl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.scenarioControl7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scenarioControl7.Location = new System.Drawing.Point(253, 3);
            this.scenarioControl7.Margin = new System.Windows.Forms.Padding(3, 3, 27, 27);
            this.scenarioControl7.MaximumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl7.MinimumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl7.Name = "scenarioControl7";
            this.scenarioControl7.ScenarioDescription = "Прогнозирование значений на основе значений временных рядов. В этом примере прогн" +
    "озируется спрос на услугу по прокату велосипедов.";
            this.scenarioControl7.ScenarioImage = global::Constructor.Properties.Resources.прогнозирование;
            this.scenarioControl7.ScenarioName = "Прогнозирование (недоступно)";
            this.scenarioControl7.Size = new System.Drawing.Size(220, 300);
            this.scenarioControl7.TabIndex = 5;
            // 
            // scenarioControl8
            // 
            this.scenarioControl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.scenarioControl8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scenarioControl8.Location = new System.Drawing.Point(503, 3);
            this.scenarioControl8.Margin = new System.Windows.Forms.Padding(3, 3, 27, 27);
            this.scenarioControl8.MaximumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl8.MinimumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl8.Name = "scenarioControl8";
            this.scenarioControl8.ScenarioDescription = "Определение групп связанных элементов без предварительного указания меток и катег" +
    "орий. ";
            this.scenarioControl8.ScenarioImage = global::Constructor.Properties.Resources.кластеризация;
            this.scenarioControl8.ScenarioName = "Кластеризация (недоступно)";
            this.scenarioControl8.Size = new System.Drawing.Size(220, 300);
            this.scenarioControl8.TabIndex = 6;
            // 
            // scenarioControl1
            // 
            this.scenarioControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.scenarioControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scenarioControl1.Location = new System.Drawing.Point(3, 3);
            this.scenarioControl1.Margin = new System.Windows.Forms.Padding(3, 3, 27, 27);
            this.scenarioControl1.MaximumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl1.MinimumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl1.Name = "scenarioControl1";
            this.scenarioControl1.ScenarioDescription = "Классификация текстовых данных на несколько категорий, например прогнозирование т" +
    "ого, являются ли комментарии позитивными или негативными.";
            this.scenarioControl1.ScenarioImage = global::Constructor.Properties.Resources.бинарная;
            this.scenarioControl1.ScenarioName = "Бинарная классификация";
            this.scenarioControl1.Size = new System.Drawing.Size(220, 300);
            this.scenarioControl1.TabIndex = 4;
            this.scenarioControl1.DoubleClick += new System.EventHandler(this.scenarioControl1_DoubleClick);
            // 
            // scenarioControl2
            // 
            this.scenarioControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.scenarioControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scenarioControl2.Location = new System.Drawing.Point(253, 3);
            this.scenarioControl2.Margin = new System.Windows.Forms.Padding(3, 3, 27, 27);
            this.scenarioControl2.MaximumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl2.MinimumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl2.Name = "scenarioControl2";
            this.scenarioControl2.ScenarioDescription = "Классификация информации на несколько категорий, например, определение болезни че" +
    "ловека.";
            this.scenarioControl2.ScenarioImage = global::Constructor.Properties.Resources.мультиклассификация;
            this.scenarioControl2.ScenarioName = "Мультиклассовая классификация";
            this.scenarioControl2.Size = new System.Drawing.Size(220, 300);
            this.scenarioControl2.TabIndex = 5;
            this.scenarioControl2.DoubleClick += new System.EventHandler(this.scenarioControl2_DoubleClick);
            // 
            // scenarioControl3
            // 
            this.scenarioControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.scenarioControl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scenarioControl3.Location = new System.Drawing.Point(503, 3);
            this.scenarioControl3.Margin = new System.Windows.Forms.Padding(3, 3, 27, 27);
            this.scenarioControl3.MaximumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl3.MinimumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl3.Name = "scenarioControl3";
            this.scenarioControl3.ScenarioDescription = "Прогнозирование числовых значений на основе данных (регрессия), например, прогноз" +
    " цены дома на основе таких признаков как размер,  расположение и т.д.";
            this.scenarioControl3.ScenarioImage = global::Constructor.Properties.Resources.прогнозирование;
            this.scenarioControl3.ScenarioName = "Прогнозирование значений (недоступно)";
            this.scenarioControl3.Size = new System.Drawing.Size(220, 300);
            this.scenarioControl3.TabIndex = 6;
            // 
            // scenarioControl4
            // 
            this.scenarioControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.scenarioControl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scenarioControl4.Location = new System.Drawing.Point(753, 3);
            this.scenarioControl4.Margin = new System.Windows.Forms.Padding(3, 3, 27, 27);
            this.scenarioControl4.MaximumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl4.MinimumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl4.Name = "scenarioControl4";
            this.scenarioControl4.ScenarioDescription = "Создание списка предлагаемых элементов для определенного пользователя, например р" +
    "екомендуемые продукты.";
            this.scenarioControl4.ScenarioImage = global::Constructor.Properties.Resources.рекомендация;
            this.scenarioControl4.ScenarioName = "Рекомендация (недоступно)";
            this.scenarioControl4.Size = new System.Drawing.Size(220, 300);
            this.scenarioControl4.TabIndex = 7;
            // 
            // scenarioControl5
            // 
            this.scenarioControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.scenarioControl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scenarioControl5.Location = new System.Drawing.Point(3, 333);
            this.scenarioControl5.Margin = new System.Windows.Forms.Padding(3, 3, 27, 27);
            this.scenarioControl5.MaximumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl5.MinimumSize = new System.Drawing.Size(220, 300);
            this.scenarioControl5.Name = "scenarioControl5";
            this.scenarioControl5.ScenarioDescription = "Обнаружение и идентификация объектов на изображениях, например, обнаружение автом" +
    "обилей.";
            this.scenarioControl5.ScenarioImage = global::Constructor.Properties.Resources.обнаружение_объектов;
            this.scenarioControl5.ScenarioName = "Обнаружение объектов (недоступно)";
            this.scenarioControl5.Size = new System.Drawing.Size(220, 300);
            this.scenarioControl5.TabIndex = 8;
            // 
            // SelectScenarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1200, 960);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectScenarioForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ScenarioControl scenarioControl1;
        private ScenarioControl scenarioControl2;
        private ScenarioControl scenarioControl3;
        private ScenarioControl scenarioControl4;
        private ScenarioControl scenarioControl5;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ScenarioControl scenarioControl6;
        private ScenarioControl scenarioControl7;
        private ScenarioControl scenarioControl8;
    }
}
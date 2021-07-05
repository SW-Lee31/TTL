
namespace Datatype0705_GUI_002
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.employee_management = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.co_num = new System.Windows.Forms.Label();
            this.co_class = new System.Windows.Forms.Label();
            this.co_level = new System.Windows.Forms.Label();
            this.employee_name = new System.Windows.Forms.Label();
            this.employee_salary = new System.Windows.Forms.Label();
            this.employee_age = new System.Windows.Forms.Label();
            this.employee_gender = new System.Windows.Forms.Label();
            this.kakao = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.Label();
            this.company_value = new System.Windows.Forms.Label();
            this.co_num_value = new System.Windows.Forms.Label();
            this.co_class_value = new System.Windows.Forms.Label();
            this.co_level_value = new System.Windows.Forms.Label();
            this.employee_name_value = new System.Windows.Forms.Label();
            this.employee_salary_value = new System.Windows.Forms.Label();
            this.employee_age_value = new System.Windows.Forms.Label();
            this.employee_gender_value = new System.Windows.Forms.Label();
            this.kakao_value = new System.Windows.Forms.Label();
            this.address_value = new System.Windows.Forms.Label();
            this.tel_value = new System.Windows.Forms.Label();
            this.detail_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(325, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(779, 1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 448);
            this.vScrollBar1.TabIndex = 2;
            // 
            // employee_management
            // 
            this.employee_management.AutoSize = true;
            this.employee_management.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.employee_management.Location = new System.Drawing.Point(254, 19);
            this.employee_management.Name = "employee_management";
            this.employee_management.Size = new System.Drawing.Size(69, 20);
            this.employee_management.TabIndex = 3;
            this.employee_management.Text = "인적사항";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Location = new System.Drawing.Point(256, 67);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(41, 12);
            this.company.TabIndex = 4;
            this.company.Text = "회사명";
            this.company.Click += new System.EventHandler(this.company_Click);
            // 
            // co_num
            // 
            this.co_num.AutoSize = true;
            this.co_num.Location = new System.Drawing.Point(256, 96);
            this.co_num.Name = "co_num";
            this.co_num.Size = new System.Drawing.Size(53, 12);
            this.co_num.TabIndex = 5;
            this.co_num.Text = "사원번호";
            // 
            // co_class
            // 
            this.co_class.AutoSize = true;
            this.co_class.Location = new System.Drawing.Point(256, 125);
            this.co_class.Name = "co_class";
            this.co_class.Size = new System.Drawing.Size(41, 12);
            this.co_class.TabIndex = 6;
            this.co_class.Text = "부서명";
            
            // 
            // co_level
            // 
            this.co_level.AutoSize = true;
            this.co_level.Location = new System.Drawing.Point(256, 153);
            this.co_level.Name = "co_level";
            this.co_level.Size = new System.Drawing.Size(29, 12);
            this.co_level.TabIndex = 7;
            this.co_level.Text = "직급";
            // 
            // employee_name
            // 
            this.employee_name.AutoSize = true;
            this.employee_name.Location = new System.Drawing.Point(256, 180);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(41, 12);
            this.employee_name.TabIndex = 8;
            this.employee_name.Text = "사원명";
            this.employee_name.Click += new System.EventHandler(this.label5_Click);
            // 
            // employee_salary
            // 
            this.employee_salary.AutoSize = true;
            this.employee_salary.Location = new System.Drawing.Point(256, 210);
            this.employee_salary.Name = "employee_salary";
            this.employee_salary.Size = new System.Drawing.Size(29, 12);
            this.employee_salary.TabIndex = 9;
            this.employee_salary.Text = "급여";
            // 
            // employee_age
            // 
            this.employee_age.AutoSize = true;
            this.employee_age.Location = new System.Drawing.Point(256, 239);
            this.employee_age.Name = "employee_age";
            this.employee_age.Size = new System.Drawing.Size(29, 12);
            this.employee_age.TabIndex = 10;
            this.employee_age.Text = "나이";
            // 
            // employee_gender
            // 
            this.employee_gender.AutoSize = true;
            this.employee_gender.Location = new System.Drawing.Point(256, 266);
            this.employee_gender.Name = "employee_gender";
            this.employee_gender.Size = new System.Drawing.Size(29, 12);
            this.employee_gender.TabIndex = 11;
            this.employee_gender.Text = "성별";
            // 
            // kakao
            // 
            this.kakao.AutoSize = true;
            this.kakao.Location = new System.Drawing.Point(256, 294);
            this.kakao.Name = "kakao";
            this.kakao.Size = new System.Drawing.Size(52, 12);
            this.kakao.TabIndex = 12;
            this.kakao.Text = "카카오ID";
            this.kakao.Click += new System.EventHandler(this.kakao_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(256, 321);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(29, 12);
            this.address.TabIndex = 13;
            this.address.Text = "주소";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(256, 347);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(53, 12);
            this.tel.TabIndex = 14;
            this.tel.Text = "전화번호";
            // 
            // detail
            // 
            this.detail.AutoSize = true;
            this.detail.Location = new System.Drawing.Point(256, 374);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(77, 12);
            this.detail.TabIndex = 15;
            this.detail.Text = "상세업무내용";
            this.detail.Click += new System.EventHandler(this.detail_Click);
            // 
            // company_value
            // 
            this.company_value.AutoSize = true;
            this.company_value.Location = new System.Drawing.Point(374, 67);
            this.company_value.Name = "company_value";
            this.company_value.Size = new System.Drawing.Size(77, 12);
            this.company_value.TabIndex = 16;
            this.company_value.Text = "회사명_value";
            // 
            // co_num_value
            // 
            this.co_num_value.AutoSize = true;
            this.co_num_value.Location = new System.Drawing.Point(374, 96);
            this.co_num_value.Name = "co_num_value";
            this.co_num_value.Size = new System.Drawing.Size(89, 12);
            this.co_num_value.TabIndex = 17;
            this.co_num_value.Text = "사원번호_value";
            // 
            // co_class_value
            // 
            this.co_class_value.AutoSize = true;
            this.co_class_value.Location = new System.Drawing.Point(374, 125);
            this.co_class_value.Name = "co_class_value";
            this.co_class_value.Size = new System.Drawing.Size(77, 12);
            this.co_class_value.TabIndex = 18;
            this.co_class_value.Text = "부서명_value";
            // 
            // co_level_value
            // 
            this.co_level_value.AutoSize = true;
            this.co_level_value.Location = new System.Drawing.Point(374, 153);
            this.co_level_value.Name = "co_level_value";
            this.co_level_value.Size = new System.Drawing.Size(65, 12);
            this.co_level_value.TabIndex = 19;
            this.co_level_value.Text = "직급_value";
            // 
            // employee_name_value
            // 
            this.employee_name_value.AutoSize = true;
            this.employee_name_value.Location = new System.Drawing.Point(374, 180);
            this.employee_name_value.Name = "employee_name_value";
            this.employee_name_value.Size = new System.Drawing.Size(77, 12);
            this.employee_name_value.TabIndex = 20;
            this.employee_name_value.Text = "사원명_value";
            // 
            // employee_salary_value
            // 
            this.employee_salary_value.AutoSize = true;
            this.employee_salary_value.Location = new System.Drawing.Point(374, 210);
            this.employee_salary_value.Name = "employee_salary_value";
            this.employee_salary_value.Size = new System.Drawing.Size(65, 12);
            this.employee_salary_value.TabIndex = 21;
            this.employee_salary_value.Text = "급여_value";
            this.employee_salary_value.Click += new System.EventHandler(this.label6_Click);
            // 
            // employee_age_value
            // 
            this.employee_age_value.AutoSize = true;
            this.employee_age_value.Location = new System.Drawing.Point(374, 239);
            this.employee_age_value.Name = "employee_age_value";
            this.employee_age_value.Size = new System.Drawing.Size(65, 12);
            this.employee_age_value.TabIndex = 22;
            this.employee_age_value.Text = "나이_value";
            // 
            // employee_gender_value
            // 
            this.employee_gender_value.AutoSize = true;
            this.employee_gender_value.Location = new System.Drawing.Point(374, 266);
            this.employee_gender_value.Name = "employee_gender_value";
            this.employee_gender_value.Size = new System.Drawing.Size(65, 12);
            this.employee_gender_value.TabIndex = 23;
            this.employee_gender_value.Text = "성별_value";
            // 
            // kakao_value
            // 
            this.kakao_value.AutoSize = true;
            this.kakao_value.Location = new System.Drawing.Point(374, 294);
            this.kakao_value.Name = "kakao_value";
            this.kakao_value.Size = new System.Drawing.Size(88, 12);
            this.kakao_value.TabIndex = 24;
            this.kakao_value.Text = "카카오ID_value";
            // 
            // address_value
            // 
            this.address_value.AutoSize = true;
            this.address_value.Location = new System.Drawing.Point(374, 321);
            this.address_value.Name = "address_value";
            this.address_value.Size = new System.Drawing.Size(65, 12);
            this.address_value.TabIndex = 25;
            this.address_value.Text = "주소_value";
            // 
            // tel_value
            // 
            this.tel_value.AutoSize = true;
            this.tel_value.Location = new System.Drawing.Point(374, 347);
            this.tel_value.Name = "tel_value";
            this.tel_value.Size = new System.Drawing.Size(89, 12);
            this.tel_value.TabIndex = 26;
            this.tel_value.Text = "전화번호_value";
            // 
            // detail_value
            // 
            this.detail_value.AutoSize = true;
            this.detail_value.Location = new System.Drawing.Point(374, 374);
            this.detail_value.Name = "detail_value";
            this.detail_value.Size = new System.Drawing.Size(113, 12);
            this.detail_value.TabIndex = 27;
            this.detail_value.Text = "상세업무내용_value";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detail_value);
            this.Controls.Add(this.tel_value);
            this.Controls.Add(this.address_value);
            this.Controls.Add(this.kakao_value);
            this.Controls.Add(this.employee_gender_value);
            this.Controls.Add(this.employee_age_value);
            this.Controls.Add(this.employee_salary_value);
            this.Controls.Add(this.employee_name_value);
            this.Controls.Add(this.co_level_value);
            this.Controls.Add(this.co_class_value);
            this.Controls.Add(this.co_num_value);
            this.Controls.Add(this.company_value);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.address);
            this.Controls.Add(this.kakao);
            this.Controls.Add(this.employee_gender);
            this.Controls.Add(this.employee_age);
            this.Controls.Add(this.employee_salary);
            this.Controls.Add(this.employee_name);
            this.Controls.Add(this.co_level);
            this.Controls.Add(this.co_class);
            this.Controls.Add(this.co_num);
            this.Controls.Add(this.company);
            this.Controls.Add(this.employee_management);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "(주)경북산업 원자재 입고 프로그램 V1.0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label employee_management;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label co_num;
        private System.Windows.Forms.Label co_class;
        private System.Windows.Forms.Label co_level;
        private System.Windows.Forms.Label employee_name;
        private System.Windows.Forms.Label employee_salary;
        private System.Windows.Forms.Label employee_age;
        private System.Windows.Forms.Label employee_gender;
        private System.Windows.Forms.Label kakao;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label detail;
        private System.Windows.Forms.Label company_value;
        private System.Windows.Forms.Label co_num_value;
        private System.Windows.Forms.Label co_class_value;
        private System.Windows.Forms.Label co_level_value;
        private System.Windows.Forms.Label employee_name_value;
        private System.Windows.Forms.Label employee_salary_value;
        private System.Windows.Forms.Label employee_age_value;
        private System.Windows.Forms.Label employee_gender_value;
        private System.Windows.Forms.Label kakao_value;
        private System.Windows.Forms.Label address_value;
        private System.Windows.Forms.Label tel_value;
        private System.Windows.Forms.Label detail_value;
    }
}


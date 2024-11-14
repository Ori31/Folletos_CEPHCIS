#pragma once
#include <string>
using namespace std;

namespace $safeprojectname$ {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Button^ btn1_sesion;

	private: System::Windows::Forms::TextBox^ txt_usuario;
	private: System::Windows::Forms::TextBox^ txt_contraseña;


	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label3;

	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->btn1_sesion = (gcnew System::Windows::Forms::Button());
			this->txt_usuario = (gcnew System::Windows::Forms::TextBox());
			this->txt_contraseña = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 15));
			this->label1->Location = System::Drawing::Point(233, 1);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(337, 96);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Servicio de folletos de la biblioteca de la unam";
			this->label1->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			this->label1->Click += gcnew System::EventHandler(this, &MyForm::label1_Click);
			// 
			// btn1_sesion
			// 
			this->btn1_sesion->BackColor = System::Drawing::Color::Gold;
			this->btn1_sesion->Location = System::Drawing::Point(317, 379);
			this->btn1_sesion->Name = L"btn1_sesion";
			this->btn1_sesion->Size = System::Drawing::Size(180, 27);
			this->btn1_sesion->TabIndex = 1;
			this->btn1_sesion->Text = L"Acceder como invitado";
			this->btn1_sesion->UseVisualStyleBackColor = false;
			this->btn1_sesion->Click += gcnew System::EventHandler(this, &MyForm::btn1_sesion_Click);
			// 
			// txt_usuario
			// 
			this->txt_usuario->Location = System::Drawing::Point(297, 185);
			this->txt_usuario->Name = L"txt_usuario";
			this->txt_usuario->Size = System::Drawing::Size(213, 22);
			this->txt_usuario->TabIndex = 3;
			this->txt_usuario->TextChanged += gcnew System::EventHandler(this, &MyForm::txt_usuario_TextChanged);
			// 
			// txt_contraseña
			// 
			this->txt_contraseña->Location = System::Drawing::Point(297, 299);
			this->txt_contraseña->Name = L"txt_contraseña";
			this->txt_contraseña->Size = System::Drawing::Size(213, 22);
			this->txt_contraseña->TabIndex = 4;
			this->txt_contraseña->TextChanged += gcnew System::EventHandler(this, &MyForm::txt_contraseña_TextChanged);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(323, 154);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(163, 16);
			this->label2->TabIndex = 5;
			this->label2->Text = L"Usuario de administración";
			this->label2->Click += gcnew System::EventHandler(this, &MyForm::label2_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(361, 270);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(79, 16);
			this->label3->TabIndex = 6;
			this->label3->Text = L"Contraseña ";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(817, 500);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->txt_contraseña);
			this->Controls->Add(this->txt_usuario);
			this->Controls->Add(this->btn1_sesion);
			this->Controls->Add(this->label1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void label1_Click(System::Object^ sender, System::EventArgs^ e) {
	}

	private: System::Void label2_Click(System::Object^ sender, System::EventArgs^ e) {
	}

		private: System::Void btn1_sesion_Click(System::Object^ sender, System::EventArgs^ e) {
			
			string usuario = this->toStandardString(this->txt_usuario->Text);
			string contrasena = this->toStandardString(this->txt_contraseña->Text);
				

			if (usuario == "Administracion" && contrasena == "Admin123") {

				MessageBox::Show(L"Bienvenido a la vista de administrador" + this->toSystemString(usuario));
			}
			else {
				MessageBox::Show(L"Usuario o contraseña equivocados");
			}
		}

		public: static string toStandardString(System::String^ string)
		{
			using System::Runtime::InteropServices::Marshal;
			System::IntPtr pointer = Marshal::StringToHGlobalAnsi(string);
			char* charPointer = reinterpret_cast<char*>(pointer.ToPointer());
			std::string returnString(charPointer, string->Length);
			Marshal::FreeHGlobal(pointer);
			return returnString;
		}

		private: static String^ toSystemString(string str) {
			return gcnew String(str.c_str());
		}
	
private: System::Void txt_usuario_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void txt_contraseña_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}



};
}

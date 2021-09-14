using CoreHtmlToImage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace signature_card_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenSignature(string name, string jobTitle, string department, string phone, string cellphone)
        {
            var cellphoneFormatted = (cellphone != null || cellphone != "" || cellphone != "+55 (XX) XXXX-XXXX" ? $"C: {cellphone}" : "");

            var htmlSkeleton = @$"
                <table width='500'>
                    <tbody>
                        <tr>
                            <td valign='middle' width='250' height='200'><img style='display: block; margin-left: auto; margin-right: auto;' src='https://1r6jvw.ch.files.1drv.com/y4mlWhmVYh4GTgrNUCiDH8PWOx1HoJCoqq7ElkDRc8pjWf8AxDzIjkzbLk_h_jyeeQjLldQt8ww73mtGH4cHCWsH6vQcoOfb-q55b0YYJp3qAWxI6gToQjdndTYnEyfF_vwv-8eDjF-rQ4LXY3lAI2fSqiC72BhBCtSJZhaiAX38-6deHpncnKcIy0UiZE5A8bkch5BCvoANvHU4mYzH6po5A/logo_01_central_sem%20fundo.png?psid=1' alt='' width='225' height='200' /></td>
                            <td width='300' height='200'><span style = 'font-size: 14px; font-weight: bold; color: #00492b;'> Hugo Oliveira Lamounier</span> <br /> <span style = 'font-size: 13px;' >{jobTitle}</span> <br /> <span style = 'font-size: 13px;' >{department}</span > <br /> <br /> <span style='font-size: 13px;'>T: {phone}<br />{cellphoneFormatted}</span> <br /><br />  <span style = 'font-size: 13px; font-weight: bold; color: #00492b;' > www.geonew.com.br </span > <br /> <br />
                                <p style='font-size: 9px; margin: 0px; text-align: justify; color: #a9a9a9;'>O conte&uacute;do desta mensagem e quaisquer anexos s&atilde;o confidenciais.Qualquer utiliza&ccedil;&atilde;o n&atilde;o autorizada &eacute; expressamente proibida.Se voc&ecirc; recebeu este e-mail por engano, por favor, notifique o remetente, desconsidere-o e exclua o e-mail.</p>
                            </td>
                        </tr>
                    </tbody>
                </table>
            ";

            var converter = new HtmlConverter();
            var bytes = converter.FromHtmlString(htmlSkeleton, 500, ImageFormat.Png);

            SaveFileDialog file = new SaveFileDialog();
            file.DefaultExt = "png";
            file.ShowDialog();

            if (file.FileName != "")
            {
                File.WriteAllBytes(file.FileName, bytes);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fullNameText = HttpUtility.HtmlEncode(name.Text);
            var jobTitleText = HttpUtility.HtmlEncode(jobTitle.Text);
            var departmentText = HttpUtility.HtmlEncode(department.Text);
            var phoneText = HttpUtility.HtmlEncode(phone.Text);
            var cellphoneText = HttpUtility.HtmlEncode(cellphone.Text);

            GenSignature(fullNameText, jobTitleText, departmentText, phoneText, cellphoneText);
        }
    }
}

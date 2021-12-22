using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RestSharp;
using Method = RestSharp.Method;
using System.Threading;

namespace Record_CameraIP
{
     public partial class Form1 : Form
     {
          private int save_Time;
          private string save_Link;

          string conStr = "data source=192.168.10.65;initial catalog=CameraTrackingSystem;user id=sa;password=123456;MultipleActiveResultSets=True;App=EntityFramework";

          Image img_tick = Image.FromFile(@"C:\Users\User\Downloads\iloveimg-resized\tick.png");
          Image img_close = Image.FromFile(@"C:\Users\User\Downloads\iloveimg-resized\close.png");

          int run_first = 0;

          public Form1()
          {
               InitializeComponent();
               SqlConnection sqlCon = new SqlConnection(conStr);
               sqlCon.Open();

               string qry_numOf_Cam = "select Camera_ID,Name,Location from CAMERA";
               SqlCommand cmd_numOf_Cam = new SqlCommand(qry_numOf_Cam, sqlCon);

               SqlDataAdapter sda_numOf_Cam = new SqlDataAdapter(cmd_numOf_Cam);
               DataTable dt_Cam = new DataTable();
               sda_numOf_Cam.Fill(dt_Cam);

               dataGridView1.DataSource = dt_Cam;

               




               sqlCon.Close();

               dataGridView1.RowTemplate.Height = 40;

               //for (int i = 0; i < dataGridView1.Rows.Count; i++)
               //{
               //     dataGridView1.Rows[i].Cells[5].Value = false;
               //}

              
               run_first = 0;

               

              
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'cameraTrackingSystemDataSet.CAMERA' table. You can move, or remove it, as needed.
               this.cAMERATableAdapter.Fill(this.cameraTrackingSystemDataSet.CAMERA);

               ///////////////////////////////////////////////////////////////////////////////////// Lấy trạng thái đang lưu hay không của camera
               SqlConnection sqlCon = new SqlConnection(conStr);
               sqlCon.Open();

               

               if (run_first == 0)
               {
                    
                    string qry_RTSP_url = "select RTSP_URL from CAMERA";

                    SqlCommand cmd_RTSP_url = new SqlCommand(qry_RTSP_url, sqlCon);

                    SqlDataAdapter sda_RTSP_url = new SqlDataAdapter(cmd_RTSP_url);
                    DataTable dt_RTSP_url = new DataTable();
                    sda_RTSP_url.Fill(dt_RTSP_url);

                    int k = 0;

                    foreach (DataRow row in dt_RTSP_url.Rows)
                    {
                         string url = row["RTSP_URL"].ToString();
                         var client = new RestClient("http://localhost:8000/get_connection_status");
                         var request = new RestRequest(Method.GET);
                         request.AddHeader("postman-token", "8cb64f2e-b33f-4f08-ecaf-cafd9a3e4260");
                         request.AddHeader("cache-control", "no-cache");
                         request.AddOrUpdateHeader("connection_path", url);
                         IRestResponse response = client.Execute(request);
                         string status = response.Content.ToString();

                         if (status == "running")
                         {
                              dataGridView1.Rows[k].Cells[4].Value = img_tick;
                         }
                         else
                         {
                              dataGridView1.Rows[k].Cells[4].Value = img_close;
                         }

                         k++;
                    }

                    
               }


               var client_1 = new RestClient("http://localhost:8000/check_camera_status");
               var request_1 = new RestRequest(Method.GET);
               request_1.AddHeader("postman-token", "92a0bba7-2cb0-ccee-caff-61e1c762fd7b");
               request_1.AddHeader("cache-control", "no-cache");

               for (int i = 0; i < dataGridView1.Rows.Count; i++)
               {
                    cam_ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string qry_RTSP = "select RTSP_URL from CAMERA where Camera_ID = " + cam_ID;
                    SqlCommand cmd_RTSP = new SqlCommand(qry_RTSP, sqlCon);

                    link_RTSP = cmd_RTSP.ExecuteScalar().ToString();
                    request_1.AddOrUpdateHeader("connection_path", link_RTSP);

                    IRestResponse response = client_1.Execute(request_1);

                    string status = response.Content;

                    if (status == "Online")
                    {
                         dataGridView1.Rows[i].Cells[3].Value = img_tick;
                         dataGridView1.Rows[i].Cells[5].ReadOnly = false;
                    }
                    else
                    {
                         dataGridView1.Rows[i].Cells[3].Value = img_close;
                         dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                    }
               }



               sqlCon.Close();
               for (int i = 0; i < dataGridView1.Rows.Count; i++)
               {
                    dataGridView1.Rows[i].Cells[5].Value = false;
               }

               run_first = 1;
          }

          

         

          private void btnRecord_Single_Click(object sender, EventArgs e)
          {
               nUP_time_Save.Enabled = false;

               SqlConnection sqlCon = new SqlConnection(conStr);
               sqlCon.Open();

               var client = new RestClient("http://localhost:8000/do_record");

               var request = new RestRequest(Method.POST);
               request.AddHeader("postman-token", "5a83ff14-ec3c-ef62-6abb-382f3e64625e");
               request.AddHeader("cache-control", "no-cache");
               request.AddHeader("movement_detected_persistence", "11");
               request.AddHeader("min_diff_for_movement", "1");
               request.AddHeader("frames_to_persist", "10");
               request.AddHeader("save_fps", "15");
               request.AddHeader("interval", nUP_time_Save.Value.ToString());
               //request.AddHeader("connection_path", link_RTSP);
               //request.AddHeader("camera_id", cam_ID);
               //IRestResponse response = client.Execute(request);


               for (int i = 0; i < dataGridView1.Rows.Count; i++)
               {
                    if(dataGridView1.Rows[i].Cells[5].Value != "")
                    {
                         bool isCellChecked = (bool)dataGridView1.Rows[i].Cells[5].Value;
                         if (isCellChecked == true)
                         {
                              dataGridView1.Rows[i].Cells[4].Value = img_tick;
                              cam_ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                              string qry_RTSP = "select RTSP_URL from CAMERA where Camera_ID = " + cam_ID;
                              SqlCommand cmd_RTSP = new SqlCommand(qry_RTSP, sqlCon);

                              link_RTSP = cmd_RTSP.ExecuteScalar().ToString();
                              request.AddOrUpdateHeader("connection_path", link_RTSP);
                              request.AddHeader("camera_id", cam_ID);
                              IRestResponse response = client.Execute(request);

                              string status = response.Content;
                              
                              if(status == "success")
                              {
                                   dataGridView1.Rows[i].Cells[4].Value = img_tick;
                              }
                              else
                              {
                                   MessageBox.Show("Camera số " + cam_ID + " đang được lưu");
                              }

                              
                         }
                         else if (dataGridView1.Rows[i].Cells[4].Value != img_tick)
                         {
                              dataGridView1.Rows[i].Cells[4].Value = img_close;
                         }
                    }
                    

               }

               sqlCon.Close();

               Form1_Load(sender, e);
          }

          string cam_ID;
          string link_RTSP;

          List<string> id_cam;

          private void btnStop_Click(object sender, EventArgs e)
          {
               nUP_time_Save.Enabled = true;

               SqlConnection sqlCon = new SqlConnection(conStr);
               sqlCon.Open();

               var client = new RestClient("http://localhost:8000/remove_connection");

               var request = new RestRequest(Method.GET);
               request.AddHeader("postman-token", "5a83ff14-ec3c-ef62-6abb-382f3e64625e");
               request.AddHeader("cache-control", "no-cache");
               
               //request.AddHeader("connection_path", link_RTSP);
               //request.AddHeader("camera_id", cam_ID);
               //IRestResponse response = client.Execute(request);


               for (int i = 0; i < dataGridView1.Rows.Count; i++)
               {
                    if (dataGridView1.Rows[i].Cells[5].Value != "")
                    {
                         bool isCellChecked = (bool)dataGridView1.Rows[i].Cells[5].Value;
                         if (isCellChecked == true)
                         {
                              cam_ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                              string qry_RTSP = "select RTSP_URL from CAMERA where Camera_ID = " + cam_ID;
                              SqlCommand cmd_RTSP = new SqlCommand(qry_RTSP, sqlCon);

                              link_RTSP = cmd_RTSP.ExecuteScalar().ToString();

                              request.AddOrUpdateHeader("connection_path", link_RTSP);
                              
                              IRestResponse response = client.Execute(request);

                              string status = response.Content;

                              if(status == "removed")
                              {
                                   dataGridView1.Rows[i].Cells[4].Value = img_close;
                              }
                              else
                              {
                                   MessageBox.Show("Chưa thể tắt trạng thái lưu");
                              }
                              
                         }
                         else if (dataGridView1.Rows[i].Cells[4].Value != img_tick)
                         {
                              dataGridView1.Rows[i].Cells[4].Value = img_close;
                         }
                    }


               }

               sqlCon.Close();

               Form1_Load(sender, e);
          }
     }
}













using Core.Configs;
using Core.DB;
using Core.Encription;
using Core.Entities;
using Core.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TestingConsole
{
    public class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            //    string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            //    UriBuilder uri = new UriBuilder(codeBase);
            //    string path = Uri.UnescapeDataString(uri.Path);
            //    path = Path.GetDirectoryName(path);
            //    string filePath = Path.Combine(path, "DBConnectionString.txt");

            //    string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            //         + "\\AccountantDesktop\\config");

            //    if (!Directory.Exists(directoryPath))
            //    {
            //        Directory.CreateDirectory(directoryPath);
            //    }


            //    filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            //         + "\\AccountantDesktop\\config\\Connect.cfg");

            //    var ss = new List<Config> { new Config() { Name = "ConnectionString", Value = "Data Source=den1.mssql2.gear.host;Initial Catalog=accountantdb;User ID=accountantdb;Password=Mikun4366644@" } };

            //    string constring = JsonConvert.SerializeObject(ss);

            //    using (Encryptor encryptor = new Encryptor())
            //    {
            //        var s = encryptor.EncryptAsync(constring).Result;
            //        using (StreamWriter write = new StreamWriter(filePath))
            //        {
            //            write.WriteLine(s);
            //            write.Close();
            //        }
            //    }

            //    using (Decryptor dec = new Decryptor())
            //    {
            //        string s = "";
            //        using (StreamReader reader = new StreamReader(filePath))
            //        {
            //            s = reader.ReadToEnd();
            //        }
            //            var con = JsonConvert.DeserializeObject<List<Config>>(dec.DecryptAsync(s).Result);
            //        Console.WriteLine();
            //        Console.ReadKey();
            //    }


            //DBConnection con = new DBConnection();
            //Console.WriteLine(con.connectionString);
            //Console.ReadKey();

            /*IRepository<ContactType> contactTypes = new ContactTypeRepository();

            contactTypes.Create(new ContactType() { ContactTypeId = Guid.NewGuid(), Name = "Phone" });
            contactTypes.Create(new ContactType() { ContactTypeId = Guid.NewGuid(), Name = "Email" });

            var contypes = contactTypes.GetList().ToList();

            var type = contactTypes.Get(contypes[0].ContactTypeId);

            contypes[1].Name = "POSHTA";

            contactTypes.Update(contypes[1]);

            foreach (var t in contypes)
            {
                contactTypes.Delete(t.ContactTypeId);
            }

            IRepository<GroupPermission> grouppermissions = new GroupPermissionRepository();

            grouppermissions.Create(new GroupPermission() { GroupPermissionId = Guid.NewGuid(), Name = "Phone" });
            grouppermissions.Create(new GroupPermission() { GroupPermissionId = Guid.NewGuid(), Name = "Email" });

            var grpper = grouppermissions.GetList().ToList();

            var permission = grouppermissions.Get(grpper[0].GroupPermissionId);

            grpper[1].Name = "POSHTA";

            grouppermissions.Update(grpper[1]);

            foreach (var t in contypes)
            {
                grouppermissions.Delete(t.ContactTypeId);
            }*/


            var db = DBManager.GetInstance();

            //var parameters = new List<Tuple<string, object>>()
            //{
            //    new Tuple<string, object>("Login", "asd"),
            //    new Tuple<string, object>("Password", "asd")
            //};

            //var t = db.ExecuteProcedure("spUserAuthorization", parameters.ToArray());


            /*FileStream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "png files (*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
           

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {   
                try
                {
                    if ((myStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)) != null)
                    {
                        using (myStream)
                        {
                            byte[] fyle;

                            var reader = new BinaryReader(myStream);

                            fyle = reader.ReadBytes((int)myStream.Length);

                            string command = "insert into users values (@id, 'asda', 'asd', 'asd', @date, @date2, null, null, @file)";

                            var parameters = new List<Tuple<string, object>>()
                            {
                                new Tuple<string, object>("id", Guid.NewGuid()),
                                new Tuple<string, object>("date", DateTime.Now),
                                new Tuple<string, object>("date2", DateTime.Now),
                                new Tuple<string, object>("file", fyle)
                            };

                            db.ExecuteCommand(command, parameters.ToArray());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }*/

            /*IRepository<Users> repository = new UserRepository();

            var t = repository.GetList().ToList();

            var u = t[0];

            var i = Image.FromStream(new MemoryStream(u.UserAvatar));

            Console.Write(i.Width + " " + i.Height);

            Console.ReadLine();*/
        }
    }
}

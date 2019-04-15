using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyThuVien.Proc;
using QuanLyThuVien;
namespace UnitTestLB
{
    [TestClass]
    public class UnitTest1
    {

        string tk1 = "admin";
        string new1 = "admin1";
        string new2 = "admin1";
        UpdateEMP update = new UpdateEMP();
        Create_Acc cre = new Create_Acc();
        CheckDate year = new CheckDate();
        Update_BookInf book = new Update_BookInf();
        ///Login-------------------
        ///"Kiểm tra đăng nhập.
        ///
        [TestMethod]
        public void LB_0001()
        {
            Login Log = new Login();
            bool actual = Log.Lo_gin("admin", "admin1");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// / Sửa tên nhân viên (ký tự là chữ).
        /// </summary>
        [TestMethod]
        public void LB_0002()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;
            
            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// /' Sửa tên nhân viên (tên nhân viên có số và kí tự đặc biệt).
        /// </summary>
        [TestMethod]
        public void LB_0003()
        {
            string tentk = "Trung";
            string mk = "147258";
            string qh = "admin";
            string tennv = "Toàn24*@";
            string dc = "Vung tau";
            string dt = "0123456789";
            string email = "Trung456@gmail.com";
            string cv = "Thu kho";
            string age = "27";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ' Sửa tên nhân viên (số kí tự phải lớn hơn 1 và nhỏ hơn 50).
        /// </summary>
        [TestMethod]
        public void LB_0004()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Nguyễn Tấn Đạt";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ' Sửa tên nhân viên (để trống).
        /// </summary>
        [TestMethod]
        public void LB_0005()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ' Sửa tên nhân viên (số kí tự lớn hơn 50).
        /// </summary>
        [TestMethod]
        public void LB_0006()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "NGUYEN DANG TU HA XUONG HONG ANH SANG CUC MANH CHAY PHAT CHET LUON A";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///' Sửa tên tài khoản (để trống).
        /// </summary>
        [TestMethod]
        public void LB_0007()
        {
            string tentk = "";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///' 'Sửa mật khẩu ̣̣̣̣̣̣(số kí tự phải lớn hơn 6 và nhỏ hơn 30).
        /// </summary>
        [TestMethod]
        public void LB_0008()
        {
            string tentk = "admin";
            string mk = "trung147";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///''Sửa mật khẩu ̣̣̣̣̣̣(số kí tự nhỏ hơn 6).
        /// </summary>
        [TestMethod]
        public void LB_0009()
        {
            string tentk = "admin";
            string mk = "a123";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///''Sửa mật khẩu ̣̣̣̣̣̣(số kí tự lớn hơn 30).
        /// </summary>
        [TestMethod]
        public void LB_00010()
        {
            string tentk = "admin";
            string mk = "NGUYEN DANG TU HA XUONG HONG ANH SANG CUC MANH CHAY PHAT CHET LUON A";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///''Sửa quyền hạn (có hai loại mặc định duy nhất admin hoặc user).
        /// </summary>
        [TestMethod]
        public void LB_0011()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///'Sửa quyền hạn (thay đổi quyền hạn được mặc định).
        /// </summary>
        [TestMethod]
        public void LB_0012()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "member";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///''Sửa địa chỉ (số kí tự bé hơn hoặc bằng 150)
        /// </summary>
        [TestMethod]
        public void LB_0013()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Ha Noi";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        //'Sửa địa chỉ ( để trống )
        /// </summary>
        [TestMethod]
        public void LB_0014()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///'Sửa địa chỉ (số kí tự lớn hơn 150)
        /// </summary>
        [TestMethod]
        public void LB_0015()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "NGUYEN DANG TU HA XUONG HONG ANH SANG CUC MANH CHAY PHAT CHET LUON A" +
                "NGUYEN DANG TU HA XUONG HONG ANH SANG CUC MANH CHAY PHAT CHET LUON A " +
                "NGUYEN DANG TU HA XUONG HONG ANH SANG CUC MANH CHAY PHAT CHET LUON A";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa số điện thoại ( ký tự là số,  số kí tự phải lớn hơn 10 và nhỏ 12)
        /// </summary>
        [TestMethod]
        public void LB_0016()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015706";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa số điện thoại ( có ký tự chữ và số).
        /// </summary>
        [TestMethod]
        public void LB_0017()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "033641sads";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        //'Sửa số điện thoại ( để trống).
        /// </summary>
        [TestMethod]
        public void LB_0018()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa số điện thoại ( số kí tự lớn hơn 12).
        /// </summary>
        [TestMethod]
        public void LB_0019()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "0811789456155";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /*


                


                

               
        */

        /// <summary>
        ///''Thay đổi email ( số ký tự nhỏ hơn 100).
        /// </summary>
        [TestMethod]
        public void LB_0020()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015706";
            string email = "Ban123@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        //'Thay đổi email ( để trống).
        /// </summary>
        [TestMethod]
        public void LB_0021()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }



        /// <summary>
        ///'''Thay đổi email (số ký tự lớn hơn 40).
        /// </summary>
        [TestMethod]
        public void LB_0022()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "daaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa chức vụ ( ký tự là chữ, số ký tự nhỏ hơn 50).
        /// </summary>
        [TestMethod]
        public void LB_0023()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "quan ly";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'''Sửa chức vụ ( ký tự là chữ, số ký tự lớn hơn 50).
        /// </summary>
        [TestMethod]
        public void LB_0024()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "adminadminadminadminadminadminadminadminadminadminadminadminadmin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa chức vụ (ký tự là số).
        /// </summary>
        [TestMethod]
        public void LB_0025()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "123456";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///''Sửa chức vụ (ký tự là số và chữ).
        /// </summary>
        [TestMethod]
        public void LB_0026()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "quản lý 123";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///''' Sửa tuổi (độ tuổi quy định 18 đến 55).
        /// </summary>
        [TestMethod]
        public void LB_0027()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "22";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///' Sửa tuổi ( số tuổi nhỏ hơn 18).
        /// </summary>
        [TestMethod]
        public void LB_0028()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "0";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///' Sửa tuổi ( số tuổi lớn hơn 55).
        /// </summary>
        [TestMethod]
        public void LB_0029()
        {
            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            string tennv = "Tan Dat";
            string dc = "TPHCM";
            string dt = "01254015705";
            string email = "dat5@gmail.com";
            string cv = "admin";
            string age = "1000";
            int emailchange = 0;
            int tentkchange = 0;

            bool actual = update.UpdateEmp2(tentk, mk, qh, tennv, dc, dt, email, cv, age, emailchange, tentkchange);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///''Nút Xóa (xóa được tài khoản là user).
        /// </summary>
        [TestMethod]
        public void LB_0030()
        {
            checkThongTinNhanVien emp = new checkThongTinNhanVien();

            string tentk = "admin";
            string mk = "admin1";
            string qh = "user";
            int emailchange = 0;
            int tentkchange = 0;

            string actual = checkThongTinNhanVien.check_delete_emp(qh, tentk);
            string expected = "Không thể xóa tài khoản admin";
            Assert.AreEqual(expected, actual);
        }  
        /// <summary>
        ///'Nút Xóa (xóa được tài khoản là admin).
        /// </summary>
        [TestMethod]
        public void LB_0031()
        {
            checkThongTinNhanVien emp = new checkThongTinNhanVien();

            string tentk = "admin";
            string mk = "admin1";
            string qh = "admin";
            int emailchange = 0;
            int tentkchange = 0;

            string actual = checkThongTinNhanVien.check_delete_emp(qh, tentk);
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

     /// <summary>
     ///' Sửa tên nhân viên (ký tự là chữ).
     /// </summary>
        [TestMethod]
        public void LB_0032()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "01254015705";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///' Sửa tên nhân viên (tên nhân viên có số và kí tự đặc biệt).
        /// </summary>
        [TestMethod]
        public void LB_0033()
        {

            string ten = "Toàn24*@";
            string dc = "TPHCM";
            string dt = "01254015705";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///' Sửa tên nhân viên (để trống).
        /// </summary>
        [TestMethod]
        public void LB_0035()
        {

            string ten = "";
            string dc = "TPHCM";
            string dt = "01254015705";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        //' Sửa tên nhân viên (số kí tự lớn hơn 50).
        /// </summary>
        [TestMethod]
        public void LB_0036()
        {

            string ten = "TùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùngTùng";
            string dc = "TPHCM";
            string dt = "01254015705";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        //'Sửa địa chỉ (số kí tự bé hơn hoặc bằng 150)
        /// </summary>
        [TestMethod]
        public void LB_0037()
        {

            string ten = "Tung";
            string dc = "HCM";
            string dt = "01254015705";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);


        }/// <summary>
         ///'Sửa địa chỉ ( để trống )
         /// </summary>
        [TestMethod]
        public void LB_0038()
        {

            string ten = "Tùng";
            string dc = "";
            string dt = "01254015705";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        //'Sửa địa chỉ (số kí tự lớn hơn 150)
        /// </summary>
        [TestMethod]
        public void LB_0039()
        {

            string ten = "Tùng";
            string dc = "TungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTung"+
                "TungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTung"+
                "TungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTungTung";
            string dt = "01254015705";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa số điện thoại ( ký tự là số,  số kí tự phải lớn hơn 10 và nhỏ 12)
        /// </summary>
        [TestMethod]
        public void LB_0040()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411123";
            string em = "";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa số điện thoại ( có ký tự chữ và số).
        /// </summary>
        [TestMethod]
        public void LB_0041()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008a";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa số điện thoại ( để trống).
        /// </summary>
        [TestMethod]
        public void LB_0042()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa số điện thoại ( số kí tự lớn hơn 12).
        /// </summary>
        [TestMethod]
        public void LB_0043()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "03364110081234123123";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        ///'Thay đổi email ( số ký tự nhỏ hơn 100).
        /// </summary>
        [TestMethod]
        public void LB_0044()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "Ban123@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///'Thay đổi email ( để trống).
        /// </summary>
        [TestMethod]
        public void LB_0045()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///'Thay đổi email (số ký tự lớn hơn 40).
        /// </summary>
        [TestMethod]
        public void LB_0046()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "dat5dat5dat5dat5dat5dat5dat5dat5dat5dat5dat5dat5dat5dat5dat5dat5dat5dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///'Sửa chức vụ ( ký tự là chữ, số ký tự nhỏ hơn 50).
        /// </summary>
        [TestMethod]
        public void LB_0047()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "dat5@gmail.com";
            string per = "quản lý";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///'Sửa chức vụ ( ký tự là chữ, số ký tự lớn hơn 50).
        /// </summary>
        [TestMethod]
        public void LB_0048()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "dat5@gmail.com";
            string per = "adminadminadminadminadminadminadminadminadminadminadmin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa chức vụ (ký tự là số).
        /// </summary>
        [TestMethod]
        public void LB_0049()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "dat5@gmail.com";
            string per = "123456";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///'Sửa chức vụ (ký tự là số và chữ).
        /// </summary>
        [TestMethod]
        public void LB_0050()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "dat5@gmail.com";
            string per = "admin123";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///' Sửa tuổi (độ tuổi quy định 18 đến 55).
        /// </summary>
        [TestMethod]
        public void LB_0051()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "20";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///' Sửa tuổi ( số tuổi nhỏ hơn 18).
        /// </summary>
        [TestMethod]
        public void LB_0052()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "-17";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///' Sửa tuổi ( số tuổi lớn hơn 55).
        /// </summary>
        [TestMethod]
        public void LB_0053()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "100";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        ///' 'Tên tài khoản (tên tài khoản trùng lập nhau).
        /// </summary>
        [TestMethod]
        public void LB_0055()
        {

            string ten = "admin";
            string pass = "dat123";
            string pass2 = "dat123";
            
            bool actual = cre.Create(ten, pass, pass2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        //ên tài khoản (số kí tự lớn hơn 1 và nhỏ hơn 50. Không có ký tư đặc biệt).
        /// </summary>
        [TestMethod]
        public void LB_0056()
        {

            string ten = "Trung123";
            string pass = "dat123";
            string pass2 = "dat123";

            bool actual = cre.Create(ten, pass, pass2);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        //ên tài khoản (số kí tự lớn hơn 1 và nhỏ hơn 50. Không có ký tư đặc biệt).
        /// </summary>
        [TestMethod]
        public void LB_0057()
        {

            string ten = "Trung123Trung123Trung123Trung123Trung123Trung123Trung123Trung123Trung123Trung123Trung123Trung123";
            string pass = "dat123";
            string pass2 = "dat123";

            bool actual = cre.Create(ten, pass, pass2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        //ê'Tên tài khoản (để trống).
        /// </summary>
        [TestMethod]
        public void LB_0058()
        {

            string ten = "";
            string pass = "dat123";
            string pass2 = "dat123";

            bool actual = cre.Create(ten, pass, pass2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        //'Sửa mật khẩu ̣̣̣̣̣̣(số kí tự phải lớn hơn 6 và nhỏ hơn 30).
        /// </summary>
        [TestMethod]
        public void LB_0059()
        {

            string ten = "trung1234";
            string pass = "123456";
            string pass2 = "123456";

            bool actual = cre.Create(ten, pass, pass2);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        //'Sửa mật khẩu ̣̣̣̣̣̣(số kí tự nhỏ hơn 6).
        /// </summary>
        [TestMethod]
        public void LB_0060()
        {

            string ten = "Trung1235";
            string pass = "a123";
            string pass2 = "a123";

            bool actual = cre.Create(ten, pass, pass2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        //'Sửa mật khẩu ̣̣̣̣̣̣(số kí tự lớn hơn 30).
        /// </summary>
        [TestMethod]
        public void LB_0061()
        {

            string ten = "Trung1235";
            string pass = "dat123dat123dat123dat123dat123dat123dat123dat123dat123dat123dat123dat123dat123";
            string pass2 = "dat123dat123dat123dat123dat123dat123dat123dat123dat123dat123dat123dat123dat123";

            bool actual = cre.Create(ten, pass, pass2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
       
        /// <summary>
        //'Xác nhận lại ( nhập không trùng khớp với mật khẩu)
        /// </summary>
        [TestMethod]
        public void LB_0063()
        {

            string ten = "Trung1234";
            string pass = "dat123";
            string pass2 = "dat123456";

            bool actual = cre.Create(ten, pass, pass2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        ///'Mật khẩu cũ (nhập trùng khớp với mật khẩu của tài khoản).
        [TestMethod]
        public void LB_0064()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "admin1";
            string passnew2 = "admin1";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        ///'Mật khẩu (Mật khẩu nhỏ hơn 6).
        [TestMethod]
        public void LB_0065()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "admin";
            string passnew2 = "admin";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            
        }


        ///'Mật khẩu (Mật khẩu mới lớn hơn 50).
        [TestMethod]
        public void LB_0066()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "111111111122222222223333333333111111111122222222223333333333";
            string passnew2 = "111111111122222222223333333333111111111122222222223333333333";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            
        }


        ///'Mật khẩu  (Mật khẩu mới không trùng nhau).
        [TestMethod]
        public void LB_0067()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "admin1";
            string passnew2 = "11111111112222222222333333333";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            
        }


        ///'Mật khẩu (Mật khẩu cũ sai).
        [TestMethod]
        public void LB_0068()
        {
            string tk = "admin";
            string passold = "matkhausai";
            string passnew = "admin1";
            string passnew2 = "admin1";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            
        }


        ///'Mật khẩu (Mật khẩu cũ để trống).
        [TestMethod]
        public void LB_0069()
        {
            string tk = "admin";
            string passold = "";
            string passnew = "admin1";
            string passnew2 = "admin1";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            
        }


        ///'Mật khẩu (Mật khẩu mới trống).
        [TestMethod]
        public void LB_0070()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "";
            string passnew2 = "";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            
        }


        /// <summary>
        ///'Tìm kiếm đơn giản ( tìm theo mã sách và để trống ô nhập truy vấn).
        /// </summary>
        [TestMethod]
        public void LB_0071()
        {
            string cbbox = "";
            string txtbox = "";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        ///''Tìm kiếm đơn giản (tìm theo mã sách và nhập đúng mã sách).
        /// </summary>
        [TestMethod]
        public void LB_0072()
        {
            string cbbox = "TENSACH";
            string txtbox = "MSA4";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("Select * from tblSach where (TENSACH like '%" + txtbox + "%' OR MASACH LIKE '%" + txtbox + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ''Tìm kiếm đơn giản( tìm theo mã sách và nhập sai mã sách).
        /// </summary>
        [TestMethod]
        public void LB_0073()
        {
            string cbbox = "TENSACH";
            string txtbox = "ABCD";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("Select * from tblSach where (TENSACH like '%" + txtbox + "%' OR MASACH LIKE '%" + txtbox + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// 'Tìm kiếm đơn giản ( tìm theo tên sách và để trống ô nhập tên sách).
        /// </summary>
        [TestMethod]
        public void LB_0074()
        {
            string cbbox = "TENSACH";
            string txtbox = "";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ''Tìm kiếm đơn giản (tìm theo tên sách và nhập đúng tên sách).
        /// </summary>
        [TestMethod]
        public void LB_0075()
        {
            string cbbox = "TENSACH";
            string txtbox = "Anh hùng xà điêu";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("Select * from tblSach where (TENSACH like '%" + txtbox + "%' OR MASACH LIKE '%" + txtbox + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        ///'Tìm kiếm đơn giản( tìm theo tên sách và nhập sai tên sách).
        /// </summary>
        [TestMethod]
        public void LB_0076()
        {
            string cbbox = "TENSACH";
            string txtbox = "ABCD bcd";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("Select * from tblSach where (TENSACH like '%" + txtbox + "%' OR MASACH LIKE '%" + txtbox + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        //'Tìm kiếm đơn giản ( tìm theo mã tác giả và để trống ô nhập mã tác giả).
        /// </summary>
        [TestMethod]
        public void LB_0077()
        {
            string cbbox = "TENTG";
            string txtbox = "";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// 'Tìm kiếm đơn giản (tìm theo tên tác giả và nhập đúng tên tác giả).
        /// </summary>
        [TestMethod]
        public void LB_0078()
        {
            string cbbox = "TENTG";
            string txtbox = "MTG2";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = "select*from tblSach where (TENTG like '%" + txtbox + "%' OR MATG LIKE '%" + txtbox + "%')";
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        ///'Tìm kiếm đơn giản( tìm theo mã tác giả và nhập sai mã tác giả).
        /// </summary>
        [TestMethod]
        public void LB_0079()
        {
            string cbbox = "TENSACH";
            string txtbox = "MABC";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = "select*from tblSach where (TENTG like '%" + txtbox + "%' OR MATG LIKE '%" + txtbox + "%')";
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        ///'Tìm kiếm đơn giản ( tìm theo mã nhà xuất bản và để trống ô nhập mã nhà xuất bản).
        /// </summary>
        [TestMethod]
        public void LB_0080()
        {
            string cbbox = "TENNXB";
            string txtbox = "";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach");
            Assert.AreEqual(expected, actual);

        }
        //'Tìm kiếm đơn giản ( tìm theo mã nhà xuất bản và nhập đúng mã nhà xuất bản).
        [TestMethod]
        public void LB_0081()
        {
            string cbbox = "TENNXB";
            string txtbox = "MNXB10";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select*from tblSach where (MANXB like '%" + txtbox + "%' OR TENNXB LIKE '%" + txtbox + "%')");
            Assert.AreEqual(expected, actual);

        }
        //'Tìm kiếm đơn giản ( tìm theo mã nhà xuất bản và nhập sai mã nhà xuất bản).
        [TestMethod]
        public void LB_0082()
        {
            string cbbox = "TENNXB";
            string txtbox = "MXNXB10112";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select*from tblSach where (MANXB like '%" + txtbox + "%' OR TENNXB LIKE '%" + txtbox + "%')");
            Assert.AreEqual(expected, actual);

        }
        //'Tìm kiếm đơn giản ( tìm theo mã lĩnh vực và để trống ô nhập mã lĩnh vực).
        [TestMethod]
        public void LB_0083()
        {
            string cbbox = "MALINHVUC";
            string txtbox = "";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach");
            Assert.AreEqual(expected, actual);

        }
        //'Tìm kiếm đơn giản ( tìm theo mã lĩnh vực và nhập đúng mã lĩnh vực).
        [TestMethod]
        public void LB_0084()
        {
            string cbbox = "MALINHVUC";
            string txtbox = "MLV10";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select*from tblSach where (MaLv like '%" + txtbox + "%')");
            Assert.AreEqual(expected, actual);

        }
        //'Tìm kiếm đơn giản ( tìm theo mã lĩnh vực và nhập sai mã lĩnh vực).
        [TestMethod]
        public void LB_0085()
        {
            string cbbox = "MALINHVUC";
            string txtbox = "MLV10123";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select*from tblSach where (MaLv like '%" + txtbox + "%')");
            Assert.AreEqual(expected, actual);

        }
        //'Tìm kiếm đơn giản ( tìm theo năm xuất bản và để trống ô nhập năm xuất bản).
        [TestMethod]
        public void LB_0086()
        {
            string cbbox = "NAMXB";
            string txtbox = "";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach");
            Assert.AreEqual(expected, actual);

        }

        //'Tìm kiếm đơn giản ( tìm theo năm xuất bản và nhập đúng năm xuất bản).
        [TestMethod]
        public void LB_0087()
        {
            string cbbox = "NAMXB";
            string txtbox = "2008";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select*from tblSach where " + cbbox + " like '%" + txtbox + "%'");
            Assert.AreEqual(expected, actual);

        }
        //'Tìm kiếm đơn giản ( tìm theo năm xuất bản và nhập  năm là ký tự).
        [TestMethod]
        public void LB_0088()
        {
            string cbbox = "NAMXB";
            string txtbox = "abc";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach");
            Assert.AreEqual(expected, actual);

        }

        //'Tìm kiếm đơn giản ( tìm theo năm xuất bản và nhập sai năm xuất bản).
        [TestMethod]
        public void LB_0089()
        {
            string cbbox = "NAMXB";
            string txtbox = "2025";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select*from tblSach where " + cbbox + " like '%" + txtbox + "%'");
            Assert.AreEqual(expected, actual);

        }

        //'Tìm kiếm đơn giản ( tìm theo ngày nhập và để trống ô ngày nhập).
        [TestMethod]
        public void LB_0090()
        {
            string cbbox = "TENTG";
            string txtbox = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach");
            Assert.AreEqual(expected, actual);

        }

        //'Tìm kiếm đơn giản ( tìm theo ngày nhập và nhập ký tự ).
        [TestMethod]
        public void LB_0091()
        {
            string cbbox = "NGAYNHAP";
            string txtbox = "abc";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri(" select * from tblSach");
            Assert.AreEqual(expected, actual);

        }


        //'Tìm kiếm đơn giản ( tìm theo ngày nhập và nhập chính xác ngày nhập).
        [TestMethod]
        public void LB_0092()
        {
            string cbbox = "NGAYNHAP";
            string txtbox = "30/06/2018";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach where " + cbbox + " like '%" + txtbox + "%'");
            Assert.AreEqual(expected, actual);

        }
        //'Tìm kiếm đơn giản ( tìm theo ngày nhập và nhập không chính xác ngày nhập).
        [TestMethod]
        public void LB_0093()
        {
            string cbbox = "NGAYNHAP";
            string txtbox = "14/09/2019";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.search_1(cbbox, txtbox));
            object expected = lg.layGiaTri("select * from tblSach where " + cbbox + " like '%" + txtbox + "%'");
            Assert.AreEqual(expected, actual);

        }

        //'Mã sách (gồm chữ và số có số ký tự lớn lớn hơn 4 nhỏ hơn 11).
        [TestMethod]
        public void LB_0094()
        {
            string ms = "ENG01dat";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2008";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = true;
            Assert.AreEqual(expected, actual);

        }

        //''Mã sách (có số ký tự nhỏ hơn 5).
        [TestMethod]
        public void LB_0095()
        {
            string ms = "TVS";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2008";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }

        //''Mã sách (có số ký tự lớn hơn 10).
        [TestMethod]
        public void LB_0096()
        {
            string ms = "TV- SGK-TANC2";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2008";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }

        //'Tên sách ( có số ký tự lớn hơn 0 và bé hơn bằng 100)
        [TestMethod]
        public void LB_0097()
        {
            string ms = "ENG01dat";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2008";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = true;
            Assert.AreEqual(expected, actual);

        }

        //'Tên sách (để trống)
        [TestMethod]
        public void LB_0098()
        {
            string ms = "ENG01dat123";
            string ts = "";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2008";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }

        //'Tên sách (có số ký tự lớn hơn 100).
        [TestMethod]
        public void LB_0099()
        {
            string ms = "ENG01da12";
            string ts = "TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2008";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }
        //'Năm xuất bản ( định dạng "yyyy" với số năm lớn hơn bằng 1900 và nhỏ hơn bằng 2019).

        [TestMethod]
        public void LB0100()
        {
            string ms = "ENG01datz";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2005";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }

        //'Năm xuất bản (nhập năm xuất bản khác định dạng năm " yyyy").
        [TestMethod]
        public void LB_0101()
        {
            string ms = "ENG01datz1";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "yyyy";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }

        //' Năm xuất bản ( số năm nhỏ hơn 1900)
        [TestMethod]
        public void LB_0102()
        {
            string ms = "ENG01dat";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "1800";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }

        //'Năm xuất bản ( số năm lớn hơn 2019).
        [TestMethod]
        public void LB_00103()
        {
            string ms = "ENG01datz3";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2024";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }

        //'Số trang ( định dạng là số dương).
        [TestMethod]
        public void LB_0104()
        {
            string ms = "ENG01dat";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2008";
            string st = "1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = true;
            Assert.AreEqual(expected, actual);

        }

        //'Số trang ( nhập khác định dạng là số dương)
        [TestMethod]
        public void LB_0105()
        {
            string ms = "ENG01datz4";
            string ts = "TIENG ANH 1";
            string tg = "MTG10";
            string mnx = "NDONG1";
            string mlv = "lv01";
            string nxb = "2008";
            string st = "-1000";
            string sl = "3000";
            string ngay = "10/08/2017";
            string gc = "";
            Login lg = new Login();
            Search search = new Search();
            bool actual = book.Update_Bookinfs(ms, ts, tg, mnx, mlv, nxb, st, sl, ngay, gc);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// ///Tìm kiếm nâng cao ( để trống hết tất cả các mục rồi bấm nút tìm).
        /// </summary>
        [TestMethod]
        public void LB_0106()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo mã sách và nhập đúng mã sách ).
        /// </summary>
        [TestMethod]
        public void LB_0107()
        {
            string MASACH = "MSA12";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo mã sách và nhập sai mã sách ).
        /// </summary>
        [TestMethod]
        public void LB_0108()
        {
            string MASACH = "MVV12";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo tên sách và nhập đúng tên sách).
        /// </summary>
        [TestMethod]
        public void LB_0109()
        {
            string MASACH = "";
            string TENSACH = " Ai la nguoi vi dai";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo tên sách và nhập sai tên sách).
        /// </summary>
        [TestMethod]
        public void LB_0110()
        {
            string MASACH = "";
            string TENSACH = " ads af";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo mã tác giả và nhập đúng mã tác giả).
        /// </summary>
        [TestMethod]
        public void LB_0111()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "MTG10";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo mã tác giả và nhập sai mã tác giả).
        /// </summary>
        [TestMethod]
        public void LB_0112()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "MTVG04";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo mã nhà xuất bản và nhập đúng mã nhà xuất bản).
        /// </summary>
        [TestMethod]
        public void LB_0113()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "MNXB13";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo mã nhà xuất bản và nhập sai mã nhà xuất bản).
        /// </summary>
        [TestMethod]
        public void LB_0114()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "MBHN132";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo mã lĩnh vực và nhập đúng mã lĩnh vực).
        /// </summary>
        [TestMethod]
        public void LB_0115()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "MLV10";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo mã lĩnh vực và nhập sai mã lĩnh vực).
        /// </summary>
        [TestMethod]
        public void LB_0116()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "MKLU123";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Tìm kiếm nâng cao ( tìm theo năm xuất bản và nhập sai năm xuất bản).
        /// </summary>
        [TestMethod]
        public void LB_0117()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "2025";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo năm xuất bản và nhập đúng năm xuất bản).
        /// </summary>
        [TestMethod]
        public void LB_0118()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "2000";
            string SOLUONG = "";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo số lượng và nhập đúng số lượng).
        /// </summary>
        [TestMethod]
        public void LB_0119()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "500";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo số lượng và nhập sai số lượng).
        /// </summary>
        [TestMethod]
        public void LB_0120()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "50000";
            string NGAYNHAP = "";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo ngày nhập và nhập đúng ngày nhập).
        /// </summary>
        [TestMethod]
        public void LB_0121()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "05/06/2016";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// ///'Tìm kiếm nâng cao ( tìm theo ngày nhập và nhập đúng ngày nhập).
        /// </summary>
        [TestMethod]
        public void LB_0122()
        {
            string MASACH = "";
            string TENSACH = "";
            string MATG = "";
            string MANXB = "";
            string MaLV = "";
            string NAMXB = "";
            string SOLUONG = "";
            string NGAYNHAP = "05/06/2055";
            Login lg = new Login();
            Search search = new Search();
            object actual = lg.layGiaTri(search.Search3(MASACH, TENSACH, MATG, MANXB, MaLV, NAMXB, SOLUONG, NGAYNHAP));
            object expected = lg.layGiaTri("select * from tblSach where (MASACH like'%" + MASACH + "%'and TENSACH like'%"
                    + TENSACH + "%'and MATG like'%" + MATG + "%'and MANXB like'%" + MANXB + "%'and MaLV like'%"
                    + MaLV + "%'and NAMXB like '%" + NAMXB + "%'and SOLUONG like '%" + SOLUONG + "%'and NGAYNHAP like '%" + NGAYNHAP + "%')");
            Assert.AreEqual(expected, actual);

        }




        [TestMethod]
        public void Test_Log_User()
        {
            Login Log = new Login();
            bool actual = Log.Permission("admin", "admin1");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Log_Amin()
        {
            Login Log = new Login();
            bool actual = Log.Permission("admin", "admin");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

    


       
      
    }
}

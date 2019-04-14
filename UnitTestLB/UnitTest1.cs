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


        ///Login-------------------
        ///"Kiểm tra đăng nhập.
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

/*
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
     /*   /// <summary>
        ///''Nút Xóa (xóa được tài khoản là user).
        /// </summary>
        [TestMethod]
        public void LB_0030()
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
        ///'Nút Xóa (xóa được tài khoản là admin).
        /// </summary>
        [TestMethod]
        public void LB_0031()
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
        */
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
    /*    /// <summary>
        ///'Sửa số điện thoại ( ký tự là số,  số kí tự phải lớn hơn 10 và nhỏ 12)
        /// </summary>
        [TestMethod]
        public void LB_0040()
        {

            string ten = "Tùng";
            string dc = "TPHCM";
            string dt = "0336411008";
            string em = "dat5@gmail.com";
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
            string dt = "0336411008";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
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
            string dt = "0336411008";
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
            string dt = "0336411008";
            string em = "dat5@gmail.com";
            string per = "admin";
            string age = "22";

            bool actual = update.UpdateEmp(ten, dc, dt, em, per, age);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        */
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


        /// Update Nhân Viên------------------
        [TestMethod]
        public void Test_Update_Emp()
        {
            UpdateEMP Up = new UpdateEMP();
            bool actual = Up.UpdateEmp("admin", "admin", "01234567891014", "admin", "admin", "admin");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }


    


        ///Pass ---------------
        [TestMethod]
        public void Test_Change_Pass()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "admin1";
            string passnew2 = "admin1";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = true;
            Assert.AreEqual(expected, actual);
            Change.Changed_Pass(tk1, passold, new1, new2);  //// Cái này là dùng để Refersh lại TK vs MK nhoa////
        }
        [TestMethod]
        public void Test_Change_Pass_Nho_Hon_6()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "admin";
            string passnew2 ="admin";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            Change.Changed_Pass(tk1, passold, new1, new2); //// Cái này là dùng để Refersh lại TK vs MK nhoa////
        }
        [TestMethod]
        public void Test_Change_Pass_Lon_Hon_30()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "111111111122222222223333333333";
            string passnew2 = "111111111122222222223333333333";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            Change.Changed_Pass(tk1, passold, new1, new2); //// Cái này là dùng để Refersh lại TK vs MK nhoa////
        }
        [TestMethod]
        public void Test_Change_Pass_Khong_Trung_MK_NEW1_NEW2()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "admin1";
            string passnew2 = "11111111112222222222333333333";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            Change.Changed_Pass(tk1, passold, new1, new2); //// Cái này là dùng để Refersh lại TK vs MK nhoa////
        }
        [TestMethod]
        public void Test_Change_Pass_Wrong_Pass_Old()
        {
            string tk = "admin";
            string passold = "matkhausai";
            string passnew = "admin1";
            string passnew2 = "11111111112222222222333333333";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            Change.Changed_Pass(tk1, "admin1", new1, new2); //// Cái này là dùng để Refersh lại TK vs MK nhoa////
        }
        [TestMethod]
        public void Test_Change_Pass_Null_Pass_Old()
        {
            string tk = "admin";
            string passold = "admin";
            string passnew = "admin1";
            string passnew2 = "11111111112222222222333333333";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            Change.Changed_Pass(tk1, "admin1", new1, new2); //// Cái này là dùng để Refersh lại TK vs MK nhoa////
        }
        [TestMethod]
        public void Test_Change_Pass_Null_Pass_New1()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "admin";
            string passnew2 = "admin1";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            Change.Changed_Pass(tk1, passold, new1, new2); //// Cái này là dùng để Refersh lại TK vs MK nhoa////
        }
        [TestMethod]
        public void Test_Change_Pass_Null_Pass_New2()
        {
            string tk = "admin";
            string passold = "admin1";
            string passnew = "admin1";
            string passnew2 = "admin";

            ChangedPass Change = new ChangedPass();
            bool actual = Change.Changed_Pass(tk, passold, passnew, passnew2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            Change.Changed_Pass(tk1, passold, new1, new2); //// Cái này là dùng để Refersh lại TK vs MK nhoa////
        }
        [TestMethod]
        public void Test_Searching1_cbBox_Null()
        {
            string cbbox = "NGAYNHAP";
            string txtbox = "admin";
            Login lg = new Login();
            Search search = new Search();
            search.search_1(cbbox, txtbox);
            object a = lg.layGiaTri(search.search_1(cbbox, txtbox));
            string actual = Convert.ToString(a);
            string expected = string.Empty;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Searching1_date()
        {
            string cbbox = "NGAYNHAP";
            string txtbox = "30/02/2018";
            CheckDate date = new CheckDate();
            date.Check_Date(txtbox);
            string actual = date.Check_Date(txtbox); ;
            string expected = "Ngày không hợp lệ";
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Searching1_Year()
        {
            string cbbox = "NAMXB";
            string txtbox = "a";
            CheckDate date = new CheckDate();
            date.Check_Year(txtbox);
            string actual = date.Check_Year(txtbox); ;
            string expected = "Năm không hợp lệ";
            Assert.AreEqual(expected, actual);

        }
    }
}

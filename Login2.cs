// 文件名称：Login2.cs
// 功能描述：登录
// 编写作者：陈伟峰
// 编写日期：2018.6.11
// 修改记录：
//      R1:
//          修改作者：邓晰
//          修改日期：2018.7.4
//          修改理由：使代码规范

using MySql.Data.MySqlClient;
using System;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Login2 : MonoBehaviour

{
    /// <summary>
    ///  用户名
    /// </summary>
    public static String uName;
    
    /// <summary>
    ///  勾选框
    /// </summary>
    public Toggle remPasswd;
    private Toggle fogPasswd;
    
    /// <summary>
    ///  注册信息
    /// </summary>
    public InputField inputName;
    public InputField inputPaswd;



    //跳转场景名称
    //public string LoadSceneName;//这个不需要这行代码

    /// <summary>
    /// GUI提示信息
    /// </summary>
    public Text ui_massage;
    private string stringMassage;


    void UpDate()
    {
        ui_massage.text = stringMassage;
    }
    

    public void OnClick()
    {
        

        string name = inputName.text.Trim();//用户名

        string password = inputPaswd.text.Trim();//密码

        string constr = "Database=user;Data Source=sh-cdb-0sbjdp2b.sql.tencentcdb.com;User Id=root;Password=se2018-g18;port=63075"; //设置连接字符串
        MySqlConnection mycon = new MySqlConnection(constr);
        mycon.Open();

        //用户名密码输入判断
        if (string.IsNullOrEmpty(name))
        {

            print(stringMassage = "提示信息：请输入昵称");
            return;
        }
        if (string.IsNullOrEmpty(password))
        {

            print(stringmMassage = "提示信息：请输入密码");
            return;
        }

        MySqlCommand mycom = mycon.CreateCommand();
        //编写SQL命令
        string s1 = "select u_name,u_pass from user where u_name='" + name + "' and u_pass='" + password + "'";
        //执行SQL命令
        mycom.CommandText = s1;                           
        MySqlDataAdapter md = new MySqlDataAdapter();
        //让适配器执行SELECT命令
        md.SelectCommand = mycom;
        //实例化结果数据集                       
        DataSet myDS = new DataSet();
        //将结果放入数据适配器，返回元祖个数                 
        int n = md.Fill(myDS, "user");              
        if (n != 0)
        {
            //登录成功
            print(stringMassage = "提示信息：登录成功");
            //记录LOADING场景中需要读取的C场景名称
            Globe.loadName = "Main";
            //先进入B场景
            Application.LoadLevel("Loading");
        }

        else
        {
            //显示提示信息
            print(stringMassage = "提示信息：用户名或密码错误");
            return;
        }

        //编写SQL命令
        string s3 = "select u_name from user where u_name = '" + name + "'and u_pass = '" + password + "'";
        //执行SQL命令
        mycom.CommandText = s3;
        MySqlDataReader re = mycom.ExecuteReader();
        if (re.Read())
        {
            uname = (String)re.GetValue(0);
        }
        //断开连接
        mycon.Close(); 
        //释放对象
        mycon.Dispose();                    
    }
    
    
    void Regist()
    {
        //显示提示信息
        print(stringMassage="提示信息：注册成功");
        //跳转到注册场景
        Application.LoadLevel("Register");

    }
}
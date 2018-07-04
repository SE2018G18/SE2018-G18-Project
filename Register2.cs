// 文件名称：Register2
// 功能描述：注册
// 编写作者：程天珂
// 编写日期：2018.6.11
// 修改记录：
//      R1:
//          修改作者：陈伟峰
//          修改日期：2018.7.4
//          修改理由：使代码规范

using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;
using UnityEngine.UI;

public class Register2 : MonoBehaviour {

    /// <summary>
    ///注册信息
    /// </summary>
    public InputField inputName;
    public InputField inputPaswd;
    public InputField inputPaswd2;


    /// <summary>
    ///跳转场景名称
    /// </summary>
    public string LoadSceneName;

    /// <summary>
    ////GUI 提示信息
    /// </summary>
    public Text ui_massage;
    private string stringmassage;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ui_massage.text = stringmassage;
    }

    void OnCLick()
    {
     
        string name = inputName.text.Trim(); //账号
        string password = inputPaswd.text.Trim();//密码
        string password2 = inputPaswd2.text.Trim();//确认密码

        //检查是否已经存在

        /**
         * 连接数据库
         */
         //设置连接字符串
        string constr = "Database=user;Data Source=sh-cdb-0sbjdp2b.sql.tencentcdb.com;User Id=root;Password=se2018-g18;pooling=false;port=63075";
        //实例化连接对象
        MySqlConnection mycon = new MySqlConnection(constr);                  
        mycon.Open();


        //查询新注册的用户是否存在

        //创建SQL命令执行对象
        MySqlCommand checkCmd = mycon.CreateCommand();       
        string s = "select u_name from user where u_name='" + name + "'";
        checkCmd.CommandText = s;
        //实例化数据适配器
        MySqlDataAdapter check = new MySqlDataAdapter();
        //让适配器执行SELECT命令
        check.SelectCommand = checkCmd;      
        //实例化结果数据集
        DataSet checkData = new DataSet();                
        //将结果放入数据适配器，返回元祖个数
        int n = check.Fill(checkData, "user");         
        if (n != 0)
        {
            print(stringmassage = "提示信息：用户名存在");
            inputName.text = ""; inputPaswd.text = "";
            inputPaswd2.text = "";
        }

        //插入数据SQL
        //编写SQL命令 
        string s1 = "insert into user(u_name,u_pass) values ('" + inputName.text + "','" + inputPaswd.text + "')";
        //初始化命令
        MySqlCommand mycom = new MySqlCommand(s1, mycon); 
        //执行语句      
        mycom.ExecuteNonQuery();            
        //关闭连接
        mycon.Close();                       
        mycom = null; 
        //释放对象
        mycon.Dispose();                    

        //确认密码
        if (inputPaswd2.text != inputPaswd.text)
        {
            inputPaswd2.text = "";
        }
        //用户名密码正确则跳转场景
        if (string.IsNullOrEmpty(name))
        {
            //显示提示信息
            print(stringmassage = "提示信息：请输入昵称");
            return;
        }
        else if (string.IsNullOrEmpty(password) || inputPaswd.text.Length != 8)
        {
            //显示提示信息
            print(stringmassage = "提示信息：请输入8位密码");
            return;
        }
        else if (string.IsNullOrEmpty(password2))
        {
            //显示提示信息
            print(stringmassage = "提示信息：请输入确认密码");
            return;
        }
        else if (password != password2)
        {
            //显示提示信息
            print(stringmassage = "提示信息：两次密码输入不正确");
            return;
        }
        else
        {
            //显示提示信息
            print(stringmassage = "提示信息：注册成功");
            Application.LoadLevel(LoadSceneName);
        }
    }

    void returntoload()
    {
        //跳转load场景
        Application.LoadLevel("load");

    }
}

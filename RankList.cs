// 文件名称：RankList
// 功能描述：排行榜
// 编写作者：邓晰
// 编写日期：2018.6.18
// 修改记录：
//      R1:
//          修改作者：程天珂
//          修改日期：2018.7.4
//          修改理由：使代码规范

using UnityEngine;
using System.Collections;
using MySql.Data.MySqlClient;
using System;

public class RankList : MonoBehaviour
{

    /// <summary>
    ///排行榜信息
    /// </summary>
    public String name1;
    public String name2;
    public String name3;
    public String name4;
    public String name5;
    public float score1;
    public float score2;
    public float score3;
    public float score4;
    public float score5;
    
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        //设置UI字体风格
        GUIStyle GS = new GUIStyle();
        //设置UI字体背景
        GS.normal.background = null;
        //设置UI字体颜色
        GS.normal.textColor = new Color(255, 0, 0);
        //设置UI字体大小
        GS.fontSize = 40;

        //设置连接字符串
        string constr = "Database=user;Data Source=sh-cdb-0sbjdp2b.sql.tencentcdb.com;User Id=root;Password=se2018-g18;port=63075";
        //实例化连接对象
        MySqlConnection mycon = new MySqlConnection(constr);
        mycon.Open();
        
        //显示排行榜第一行信息
        MySqlCommand mycom1 = mycon.CreateCommand();
        //判断哪个排行榜
        if (Application.loadedLevelName == "Rank1")
        {
            //编写SQL命令 
            string s1 = "select u_name1,u_score1 from Rank1 order by u_score1 desc limit 0,1";
            //执行SQL命令
            mycom1.CommandText = s1;
            MySqlDataReader re1 = mycom1.ExecuteReader();
            if (re1.Read())
            {
                name1 = (String)re1.GetValue(0);
                score1 = (float)re1.GetValue(1);
            }
            re1.Close();

        }
        else if (Application.loadedLevelName == "Rank2")
        {
            //编写SQL命令 
            string s1 = "select u_name2,u_score2 from Rank2 order by u_score2 desc limit 0,1";
            //执行SQL命令
            mycom1.CommandText = s1;
            MySqlDataReader re1 = mycom1.ExecuteReader();
            if (re1.Read())
            {
                name1 = (String)re1.GetValue(0);
                score1 = (float)re1.GetValue(1);
            }
            re1.Close();
            
        }
        else if (Application.loadedLevelName == "Rank3")
        {
            //编写SQL命令 
            string s1 = "select u_name3,u_score3 from Rank3 order by u_score3 desc limit 0,1";
            //执行SQL命令
            mycom1.CommandText = s1;
            MySqlDataReader re1 = mycom1.ExecuteReader();
            if (re1.Read())
            {
                name1 = (String)re1.GetValue(0);
                score1 = (float)re1.GetValue(1);
            }
            re1.Close();

        }
        //显示排行榜信息
        GUI.Label(new Rect(750, 400, 200, 100), name1, GS);
        GUI.Label(new Rect(1050, 400, 200, 100), score1.ToString(), GS);

        //显示排行榜第二行信息
        MySqlCommand mycom2 = mycon.CreateCommand();
        if (Application.loadedLevelName == "Rank1")
        {
            //编写SQL命令 
            string s2 = "select u_name1,u_score1 from Rank1 order by u_score1 desc limit 1,1";
            //执行SQL命令
            mycom2.CommandText = s2;
            MySqlDataReader re2 = mycom2.ExecuteReader();
            if (re2.Read())
            {
                name2 = (String)re2.GetValue(0);
                score2 = (float)re2.GetValue(1);
            }
            re2.Close();

        }
        else if (Application.loadedLevelName == "Rank2")
        {
            //编写SQL命令 
            string s2 = "select u_name2,u_score2 from Rank2 order by u_score2 desc limit 1,1";
            //执行SQL命令
            mycom2.CommandText = s2;
            MySqlDataReader re2 = mycom2.ExecuteReader();
            if (re2.Read())
            {
                name2 = (String)re2.GetValue(0);
                score2 = (float)re2.GetValue(1);
            }
            re2.Close();
        }
        else if (Application.loadedLevelName == "Rank3")
        {
            //编写SQL命令 
            string s2 = "select u_name3,u_score3 from Rank3 order by u_score3 desc limit 1,1";
            //执行SQL命令
            mycom2.CommandText = s2;
            MySqlDataReader re2 = mycom2.ExecuteReader();
            if (re2.Read())
            {
                name2 = (String)re2.GetValue(0);
                score2 = (float)re2.GetValue(1);
            }

            re2.Close();
        }
        //显示排行榜信息
        GUI.Label(new Rect(750, 450, 200, 100), name2, GS);
        GUI.Label(new Rect(1050, 450, 200, 100), score2.ToString(), GS);

        //显示排行榜第三行信息
        MySqlCommand mycom3 = mycon.CreateCommand();
        if (Application.loadedLevelName == "Rank1")
        {
            //编写SQL命令 
            string s3 = "select u_name1,u_score1 from Rank1 order by u_score1 desc limit 2,1";
            //执行SQL命令
            mycom3.CommandText = s3;
            MySqlDataReader re3 = mycom3.ExecuteReader();
            if (re3.Read())
            {
                name3 = (String)re3.GetValue(0);
                score3 = (float)re3.GetValue(1);
            }
            re3.Close();

        }
        else if (Application.loadedLevelName == "Rank2")
        {
            //编写SQL命令 
            string s3 = "select u_name2,u_score2 from Rank2 order by u_score2 desc limit 2,1";
            //执行SQL命令
            mycom3.CommandText = s3;
            MySqlDataReader re3 = mycom3.ExecuteReader();
            if (re3.Read())
            {
                name3 = (String)re3.GetValue(0);
                score3 = (float)re3.GetValue(1);
            }
            re3.Close();

        }
        else if (Application.loadedLevelName == "Rank3")
        {
            //编写SQL命令 
            string s3 = "select u_name3,u_score3 from Rank3 order by u_score3 desc limit 2,1";
            //执行SQL命令
            mycom3.CommandText = s3;
            MySqlDataReader re3 = mycom3.ExecuteReader();
            if (re3.Read())
            {
                name3 = (String)re3.GetValue(0);
                score3 = (float)re3.GetValue(1);
            }
            re3.Close();


        }
        //显示排行榜信息
        GUI.Label(new Rect(750, 500, 200, 100), name3, GS);
        GUI.Label(new Rect(1050, 500, 200, 100), score3.ToString(), GS);


        //显示排行榜第四行信息
        MySqlCommand mycom4 = mycon.CreateCommand();
        if (Application.loadedLevelName == "Rank1")
        {
            //编写SQL命令 
            string s4 = "select u_name1,u_score1 from Rank1 order by u_score1 desc limit 3,1";
            //执行SQL命令
            mycom4.CommandText = s4;
            MySqlDataReader re4 = mycom4.ExecuteReader();
            if (re4.Read())
            {
                name4 = (String)re4.GetValue(0);
                score4 = (float)re4.GetValue(1);
            }
            re4.Close();

        }
        else if (Application.loadedLevelName == "Rank2")
        {
            //编写SQL命令 
            string s4 = "select u_name2,u_score2 from Rank2 order by u_score2 desc limit 3,1";
            //执行SQL命令
            mycom4.CommandText = s4;
            MySqlDataReader re4 = mycom4.ExecuteReader();
            if (re4.Read())
            {
                name4 = (String)re4.GetValue(0);
                score4 = (float)re4.GetValue(1);
            }

            re4.Close();
        }
        else if (Application.loadedLevelName == "Rank3")
        {
            //编写SQL命令 
            string s4 = "select u_name3,u_score3 from Rank3 order by u_score3 desc limit 3,1";
            //执行SQL命令
            mycom4.CommandText = s4;
            MySqlDataReader re4 = mycom4.ExecuteReader();
            if (re4.Read())
            {
                name4 = (String)re4.GetValue(0);
                score4 = (float)re4.GetValue(1);
            }
            re4.Close();
        }
        //显示排行榜信息
        GUI.Label(new Rect(750, 550, 200, 100), name4, GS);
        GUI.Label(new Rect(1050, 550, 200, 100), score4.ToString(), GS);

        //显示排行榜第一行信息
        MySqlCommand mycom5 = mycon.CreateCommand();
        if (Application.loadedLevelName == "Rank1")
        {
            //编写SQL命令 
            string s5 = "select u_name1,u_score1 from Rank1 order by u_score1 desc limit 4,1";
            //执行SQL命令
            mycom5.CommandText = s5;
            MySqlDataReader re5 = mycom5.ExecuteReader();
            if (re5.Read())
            {
                name5 = (String)re5.GetValue(0);
                score5 = (float)re5.GetValue(1);
            }
            re5.Close();
        }
        else if (Application.loadedLevelName == "Rank2")
        {
            //编写SQL命令 
            string s5 = "select u_name2,u_score2 from Rank2 order by u_score2 desc limit 4,1";
            //执行SQL命令
            mycom5.CommandText = s5;
            MySqlDataReader re5 = mycom5.ExecuteReader();
            if (re5.Read())
            {
                name5 = (String)re5.GetValue(0);
                score5 = (float)re5.GetValue(1);
            }
            re5.Close();
        }
        else if (Application.loadedLevelName == "Rank3")
        {
            //编写SQL命令 
            string s5 = "select u_name3,u_score3 from Rank3 order by u_score3 desc limit 4,1";
            //执行SQL命令
            mycom5.CommandText = s5;
            MySqlDataReader re5 = mycom5.ExecuteReader();
            if (re5.Read())
            {
                name5 = (String)re5.GetValue(0);
                score5 = (float)re5.GetValue(1);
            }
            re5.Close();
        }
        //显示排行榜信息
        GUI.Label(new Rect(750, 600, 200, 100), name5, GS);
        GUI.Label(new Rect(1050, 600, 200, 100), score5.ToString(), GS);

        //关闭连接
        mycon.Close();
        //释放对象
        mycon.Dispose();                     
    }
    
        
 }

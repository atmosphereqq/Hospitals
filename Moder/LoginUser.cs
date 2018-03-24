using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class LoginUser
    {
        public string     Id        { get; set; }               //用户编号  
        public string PassWord { get; set; }
        public string     LastLogin      { get; set; }          //上次登录时间    
        public Boolean    IsSuperUser      { get; set; }         
        public string     UserName        { get; set; }               
        public string     FistName          { get; set; }                	
        public string     LastName       { get; set; }           	
        public string     Email         { get; set; }               	
        public Boolean    IsStaff         { get; set; }             
        public Boolean    IsActive          { get; set; }           
        public DateTime   DateJoined       { get; set; }             
    }
}    
                                                                                 
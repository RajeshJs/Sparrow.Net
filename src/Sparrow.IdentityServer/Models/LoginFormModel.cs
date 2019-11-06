﻿using System.ComponentModel.DataAnnotations;

namespace Sparrow.IdentityServer.Models
{
    /// <summary>
    /// 登录表单模型
    /// </summary>
    public class LoginFormModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Display(Name = "账号")]
        [Required(ErrorMessage = "账号必填")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Display(Name = "密码")]
        [Required(ErrorMessage = "密码必填")]
        public string Password { get; set; }

        /// <summary>
        /// 记住账号
        /// </summary>
        [Display(Name = "记住账号？")]
        public bool RememberMe { get; set; }

        /// <summary>
        /// 返回 url
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
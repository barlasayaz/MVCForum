﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MVCForum.Domain.DomainModel;
using MVCForum.Website.Application;

namespace MVCForum.Website.Areas.Admin.ViewModels
{

    #region Users

    public class SingleMemberListViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "User Name")]        
        public string UserName { get; set; }

        [Display(Name = "Locked Out")]
        public bool IsLockedOut { get; set; }

        [Display(Name = "Approved")]
        public bool IsApproved { get; set; }

        [Display(Name = "Roles")]
        public string[] Roles { get; set; }
    }

    public class MemberListViewModel
    {
        [Required]
        [Display(Name = "Users")]
        public IList<SingleMemberListViewModel> Users { get; set; }

        [Required]
        [Display(Name = "Roles")]
        public IList<MembershipRole> AllRoles { get; set; }

        public Guid Id { get; set; }

        public int? PageIndex { get; set; }
        public int? TotalCount { get; set; }
        public int TotalPages { get; set; }
        public string Search { get; set; }

    }

    public class MemberEditViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "User Name")]
        [StringLength(150)]
        public string UserName { get; set; }

        [Display(Name = "Users Uploaded Avatar")]
        public string Avatar { get; set; }

        [Display(Name = "Password Question")]
        public string PasswordQuestion { get; set; }

        [Display(Name = "Password Answer")]
        public string PasswordAnswer { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Signature")]
        [StringLength(1000)]
        [UIHint(SiteConstants.EditorType), AllowHtml]
        public string Signature { get; set; }

        [Display(Name = "Age")]
        [Range(0, int.MaxValue)]
        public int? Age { get; set; }

        [Display(Name = "Location")]
        [StringLength(100)]
        public string Location { get; set; }

        [Display(Name = "Website")]
        [System.ComponentModel.DataAnnotations.Url]
        [StringLength(100)]
        public string Website { get; set; }

        [Display(Name = "Twitter Url")]
        [System.ComponentModel.DataAnnotations.Url]
        [StringLength(60)]
        public string Twitter { get; set; }

        [Display(Name = "Facebook Page")]
        [System.ComponentModel.DataAnnotations.Url]
        [StringLength(60)]
        public string Facebook { get; set; }

        [Display(Name = "User is Approved")]
        public bool IsApproved { get; set; }

        [Display(Name = "Disable email notifications for this member")]
        public bool DisableEmailNotifications { get; set; }
        
        [Display(Name = "Disable posting. The user will not be able to post or create topics")]
        public bool DisablePosting { get; set; }
        
        [Display(Name = "Disable private messages for this user")]
        public bool DisablePrivateMessages { get; set; }

        [Display(Name = "Disable file uploading on posts and topics for this user")]
        public bool DisableFileUploads { get; set; }

        [Display(Name = "User is Locked Out")]
        public bool IsLockedOut { get; set; }

        [Display(Name = "User is Banned")]
        public bool IsBanned { get; set; }

        [Display(Name = "Comment")]
        public string Comment { get; set; }

        [Display(Name = "Roles")]
        public string[] Roles { get; set; }

        public IList<MembershipRole> AllRoles { get; set; }

    }

    #endregion

    #region Roles

    public class AjaxRoleUpdateViewModel
    {
        public Guid Id { get; set; }
        public string[] Roles { get; set; }
    }

    public class RoleListViewModel
    {
        public IList<MembershipRole> MembershipRoles { get; set; }
    }

    public class RoleViewModel
    {
        [Required]
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

    }


    #endregion

}

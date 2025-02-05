﻿using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    internal class ZenosSlashCommands
    {
        public static ApplicationCommandProperties[] Zenos_SC = new ApplicationCommandProperties[]
        {

            // admin slash commands

            new SlashCommandBuilder()
                .WithName("a_answer")
                .WithDescription(StringT.Scd_a_answer)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_userinfo")
                .WithDescription(StringT.Scd_a_userinfo)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("name")
                    .WithDescription(StringT.Scd_usermention)
                    .WithType(ApplicationCommandOptionType.User)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_set_answer")
                .WithDescription(StringT.Scd_a_set_answer)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("channel")
                    .WithDescription(StringT.Scd_ctt_d)
                    .WithType(ApplicationCommandOptionType.Channel)
                    .AddChannelType(ChannelType.Text)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_set_log")
                .WithDescription(StringT.Scd_a_set_log)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("channell")
                    .WithDescription(StringT.Scd_ctt_d)
                    .WithType(ApplicationCommandOptionType.Channel)
                    .AddChannelType(ChannelType.Text)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_set_ffnews")
                .WithDescription(StringT.Scd_a_set_ffnews)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("newsc")
                    .WithDescription(StringT.Scd_ctt_d)
                    .WithType(ApplicationCommandOptionType.Channel)
                    .AddChannelType(ChannelType.Text)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_show_stored")
                .WithDescription(StringT.Scd_a_show_stored)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_sendmsg")
                .WithDescription(StringT.Scd_a_sendmsg)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                        .WithName("title")
                        .WithDescription(StringT.Scd_a_sendmsg_d1)
                        .WithType(ApplicationCommandOptionType.String)
                        .WithRequired(true))
                .AddOption(new SlashCommandOptionBuilder()
                        .WithName("msg")
                        .WithDescription(StringT.Scd_a_sendmsg_d2)
                        .WithType(ApplicationCommandOptionType.String)
                        .WithRequired(true))
                .AddOption(new SlashCommandOptionBuilder()
                        .WithName("picture")
                        .WithDescription(StringT.Scd_a_sendmsg_d3)
                        .WithType(ApplicationCommandOptionType.String)
                        .WithRequired(false))
                .AddOption(new SlashCommandOptionBuilder()
                        .WithName("channel")
                        .WithDescription(StringT.Scd_a_sendmsg_d4)
                        .WithType(ApplicationCommandOptionType.Channel)
                        .AddChannelType(ChannelType.Text)
                        .WithRequired(false))
                .AddOption(new SlashCommandOptionBuilder()
                        .WithName("mention")
                        .WithDescription(StringT.Scd_a_sendmsg_d5)
                        .WithType(ApplicationCommandOptionType.Boolean)
                        .WithRequired(false))
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_react")
                .WithDescription(StringT.Scd_a_react)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                 .AddOption(new SlashCommandOptionBuilder()
                    .WithName("message_link")
                    .WithDescription(StringT.Scd_a_react_d1)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("emote")
                    .WithDescription(StringT.Scd_a_react_d2)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_nikname")
                .WithDescription(StringT.Scd_a_nikname)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("name")
                    .WithDescription(StringT.Scd_usermention)
                    .WithType(ApplicationCommandOptionType.User)
                    .WithRequired(true))
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("nik")
                    .WithDescription(StringT.Scd_a_nikname_d)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_log")
                .WithDescription(StringT.Scd_a_log)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("logname")
                    .WithDescription(StringT.Scd_a_log_d)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(false))
                .Build(),

            new SlashCommandBuilder()
                .WithName("badwordslist")
                .WithDescription(StringT.Scd_dwlist)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .Build(),

            new SlashCommandBuilder()
                .WithName("addword")
                .WithDescription(StringT.Scd_addword)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("newword")
                    .WithDescription(StringT.Scd_addword_d)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("removeword")
                .WithDescription(StringT.Scd_removeword)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("word")
                    .WithDescription(StringT.Scd_removeword_d)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .WithName("warnlist")
                .WithDescription(StringT.Scd_warnlist)
                .Build(),

            new SlashCommandBuilder()
                .WithName("warn")
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("name")
                    .WithDescription(StringT.Scd_warn_d1)
                    .WithType(ApplicationCommandOptionType.User)
                    .WithRequired(true))
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("reason")
                    .WithDescription(StringT.Scd_warn_d2)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .WithDescription(StringT.Scd_warn)
                .Build(),

            new SlashCommandBuilder()
                .WithName("a_status")
                .WithDescription(StringT.Scd_searchoutfit)
                .WithDefaultMemberPermissions(GuildPermission.Administrator)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("status")
                    .WithDescription(StringT.Scd_searchoutfit_d)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .Build(),



            /* 
             * user slash commands
             */
            
            
            new SlashCommandBuilder()
                .WithName("timers")
                .WithDescription(StringT.Scd_timers)
                .Build(),


            new SlashCommandBuilder()
            .WithName("ffmaintenancenow")
            .WithDescription(StringT.Scd_ffmaintenencenow)
            .AddOption(new SlashCommandOptionBuilder()
                    .WithName("number")
                    .WithDescription(StringT.Scd_desc_hmn)
                    .WithType(ApplicationCommandOptionType.Integer)
                    .WithRequired(false)
                    )
                .Build(),
            new SlashCommandBuilder()
                .WithName("timestamp")
                .WithDescription(StringT.Scd_timestamp)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("time")
                    .WithDescription(StringT.Scd_timestamp_d )
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("searchmount")
                .WithDescription(StringT.Scd_searchmount)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("mount")
                    .WithDescription(StringT.Scd_searchmount_d)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("searchminion")
                .WithDescription(StringT.Scd_searchminion)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("minion")
                    .WithDescription(StringT.Scd_searchminion_d)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("searchoutfit")
                .WithDescription(StringT.Scd_searchoutfit)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("outfit")
                    .WithDescription(StringT.Scd_searchoutfit_d)
                    .WithType(ApplicationCommandOptionType.String)
                    .WithRequired(true))
                .Build(),

            new SlashCommandBuilder()
                .WithName("cacpot")
                .WithDescription(StringT.Scd_cacpot)
                .Build(),

            new SlashCommandBuilder()
                .WithName("botinfo")
                .WithDescription(StringT.Scd_botinfo)
                .Build()


            
            /* ff notices, updates.....
            new SlashCommandBuilder()
                .WithName("fftopics")
                .WithDescription(StringT.Scd_ffnews)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("number")
                    .WithDescription(StringT.Scd_desc_hmn)
                    .WithType(ApplicationCommandOptionType.Integer)
                    .WithRequired(false)
                    )
                .Build(),
            new SlashCommandBuilder()
                .WithName("ffstatus")
                .WithDescription(StringT.Scd_ffstatus)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("number")
                    .WithDescription(StringT.Scd_desc_hmn)
                    .WithType(ApplicationCommandOptionType.Integer)
                    .WithRequired(false)
                    )
                .Build(),

            new SlashCommandBuilder()
                .WithName("ffmaintenance")
                .WithDescription(StringT.Scd_ffmaintenence)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("number")
                    .WithDescription(StringT.Scd_desc_hmn)
                    .WithType(ApplicationCommandOptionType.Integer)
                    .WithRequired(false)
                    )
                .Build(),
            
            new SlashCommandBuilder()
            .WithName("ffupdates")
            .WithDescription(StringT.Scd_ffupdates)
            .AddOption(new SlashCommandOptionBuilder()
                .WithName("number")
                .WithDescription(StringT.Scd_desc_hmn)
                .WithType(ApplicationCommandOptionType.Integer)
                .WithRequired(false)
                    )
                .Build(),

            new SlashCommandBuilder()
                .WithName("ffnotices")
                .WithDescription(StringT.Scd_ffnotices)
                .AddOption(new SlashCommandOptionBuilder()
                    .WithName("number")
                    .WithDescription(StringT.Scd_desc_hmn)
                    .WithType(ApplicationCommandOptionType.Integer)
                    .WithRequired(false))
                .Build(),
             */
        };
    }
}

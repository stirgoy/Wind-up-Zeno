using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wind_up_Zeno
{
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            LstRoles.DataSource = null;
            LstRoles.Items.Clear();
            LstRoles.DataSource = Core.Bot.GetKuruRoles().ToList();
            if(LstRoles.Items.Count > 0)
            {
                LstRoles.SelectedIndex = 0;
            }
        }

        private void LstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstRoles.Items.Count > 0)
            {
                if (LstRoles.SelectedIndex > -1)
                {
                    LstPermA.DataSource = null;
                    LstPermI.DataSource = null;
                    LstPermA.Items.Clear();
                    LstPermI.Items.Clear();
                    LstPermA.DataSource = (LstRoles.SelectedItem as SocketRole).Permissions.ToList();
                    var r = Enum.GetNames(typeof(GuildPermission)).ToList();
                    foreach( var i in LstPermA.Items)
                    {
                        r.Remove(i.ToString());
                    }
                    LstPermI.DataSource = r;

                    label2.Text = $"Active permissions: {LstPermA.Items.Count}";
                    label3.Text = $"Inactive permissions: {LstPermI.Items.Count}";

                    UpdateChks();
                }


            }
        }

        private void UpdateChks()
        {
            /*
            foreach (var item in LstPermI.Items)
            {
                ChkHandler((GuildPermission)Enum.Parse(typeof(GuildPermission), item.ToString()), false);
            }*/
            
            foreach (var item in Enum.GetValues(typeof(GuildPermission)))
            {
                ChkHandler((GuildPermission)Enum.Parse(typeof(GuildPermission), item.ToString()), false);
            }

            foreach (GuildPermission item in LstPermA.Items)
            {
                ChkHandler((GuildPermission)Enum.Parse(typeof(GuildPermission), item.ToString()), true);

            }

        }

        private async void ChkHandler(GuildPermission chk, bool  isactive)
        {
            switch (chk)
            {                
                case GuildPermission.CreateInstantInvite:
                    ChkCreateInstantInvite.Checked = isactive;
                    break;
                case GuildPermission.KickMembers:
                    ChkKickMembers.Checked = isactive;
                    break;
                case GuildPermission.BanMembers:
                    ChkBanMembers.Checked = isactive;
                    break;
                case GuildPermission.Administrator:
                    ChkAdministrator.Checked = isactive;
                    break;
                case GuildPermission.ManageChannels:
                    ChkManageChannels.Checked = isactive;
                    break;
                case GuildPermission.ManageGuild:
                    ChkManageGuild.Checked = isactive;
                    break;
                case GuildPermission.ViewGuildInsights:
                    ChkViewGuildInsights.Checked = isactive;
                    break;
                case GuildPermission.AddReactions:
                    ChkAddReactions.Checked = isactive;
                    break;
                case GuildPermission.ViewAuditLog:
                    ChkViewAuditLog.Checked = isactive;
                    break;
                case GuildPermission.ViewChannel:
                    ChkViewChannel.Checked = isactive;
                    break;
                case GuildPermission.SendMessages:
                    ChkSendMessages.Checked = isactive;
                    break;
                case GuildPermission.SendTTSMessages:
                    ChkSendTTSMessages.Checked = isactive;
                    break;
                case GuildPermission.ManageMessages:
                    ChkManageMessages.Checked = isactive;
                    break;
                case GuildPermission.EmbedLinks:
                    ChkEmbedLinks.Checked = isactive;
                    break;
                case GuildPermission.AttachFiles:
                    ChkAttachFiles.Checked = isactive;
                    break;
                case GuildPermission.ReadMessageHistory:
                    ChkReadMessageHistory.Checked = isactive;
                    break;
                case GuildPermission.MentionEveryone:
                    ChkMentionEveryone.Checked = isactive;
                    break;
                case GuildPermission.UseExternalEmojis:
                    ChkUseExternalEmojis.Checked = isactive;
                    break;
                case GuildPermission.Connect:
                    ChkConnect.Checked = isactive;
                    break;
                case GuildPermission.Speak:
                    ChkSpeak.Checked = isactive;
                    break;
                case GuildPermission.MuteMembers:
                    ChkMuteMebers.Checked = isactive;
                    break;
                case GuildPermission.DeafenMembers:
                    ChkDeafenMembers.Checked = isactive;
                    break;
                case GuildPermission.MoveMembers:
                    ChkMoveMembers.Checked = isactive;
                    break;
                case GuildPermission.UseVAD:
                    ChkUseVad.Checked = isactive;
                    break;
                case GuildPermission.PrioritySpeaker:
                    ChkPrioritySpeaker.Checked = isactive;
                    break;
                case GuildPermission.Stream:
                    ChkStream.Checked = isactive;
                    break;
                case GuildPermission.ChangeNickname:
                    ChkChangeNickname.Checked = isactive;
                    break;
                case GuildPermission.ManageNicknames:
                    ChkManageNicknames.Checked = isactive;
                    break;
                case GuildPermission.ManageRoles:
                    ChkManageRoles.Checked = isactive;
                    break;
                case GuildPermission.ManageWebhooks:
                    ChkManageWebHooks.Checked = isactive;
                    break;
                case GuildPermission.ManageEmojisAndStickers:
                    ChkManageEmojisAndStickers.Checked = isactive;
                    break;
                case GuildPermission.UseApplicationCommands:
                    ChkUseApplicationCommands.Checked = isactive;
                    break;
                case GuildPermission.RequestToSpeak:
                    ChkRequestToSpeak.Checked = isactive;
                    break;
                case GuildPermission.ManageEvents:
                    ChkManageEvents.Checked = isactive;
                    break;
                case GuildPermission.ManageThreads:
                    ChkManageThreads.Checked = isactive;
                    break;
                case GuildPermission.CreatePublicThreads:
                    ChkCreatePublicThreads.Checked = isactive;
                    break;
                case GuildPermission.CreatePrivateThreads:
                    ChkCreatePrivateThreads.Checked = isactive;
                    break;
                case GuildPermission.UseExternalStickers:
                    ChkUseExternalStickers.Checked = isactive;
                    break;
                case GuildPermission.SendMessagesInThreads:
                    ChkSendMessagesInThreads.Checked = isactive;
                    break;
                case GuildPermission.StartEmbeddedActivities:
                    ChkStartEmbeddedActivities.Checked = isactive;
                    break;
                case GuildPermission.ModerateMembers:
                    ChkModerteMembers.Checked = isactive;
                    break;
                case GuildPermission.ViewMonetizationAnalytics:
                    ChkViewMonetizationAnalytics.Checked = isactive;
                    break;
                case GuildPermission.UseSoundboard:
                    ChkUseSoundboard.Checked = isactive;
                    break;
                case GuildPermission.CreateGuildExpressions:
                    ChkCreateGuildExpressions.Checked = isactive;
                    break;
                case GuildPermission.CreateEvents:
                    ChkCreateEvents.Checked = isactive;
                    break;
                case GuildPermission.UseExternalSounds:
                    ChkUseExternalSounds.Checked = isactive;
                    break;
                case GuildPermission.SendVoiceMessages:
                    ChkSendMessages.Checked = isactive;
                    break;
                case GuildPermission.UseClydeAI:
                    ChkUseClydeAI.Checked = isactive;
                    break;
                case GuildPermission.SetVoiceChannelStatus:
                    ChkSetVoiceChannelStatus.Checked = isactive;
                    break;
                case GuildPermission.SendPolls:
                    ChkSendPolls.Checked= isactive;
                    break;
                case GuildPermission.UseExternalApps:
                    ChkUseSoundboard.Checked = isactive;
                    break;
                
                default:
                    await Core.Bot.LogForm($"{chk} not found");
                    break;
            }
        }

        private async void BtnDisable_Click(object sender, EventArgs e)
        {
            if (LstPermA.Items.Count > 0)
            {
                if(LstPermA.SelectedIndex> -1)
                {
                    if (!(LstRoles.SelectedItem is SocketRole curRole)) return;

                    // Convertir el permiso seleccionado de string a GuildPermission
                    GuildPermission selectedPermission = (GuildPermission)Enum.Parse(typeof(GuildPermission), LstPermA.SelectedItem.ToString());

                    // Crear una nueva lista de permisos desactivando el seleccionado
                    GuildPermissions newPermissions = new GuildPermissions(curRole.Permissions.RawValue & ~(ulong)selectedPermission);

                    try
                    {

                        // Aplicar los cambios al rol
                        await curRole.ModifyAsync(properties =>
                        {
                            properties.Permissions = newPermissions;
                        });

                        // Actualizar la lista de permisos en la UI
                        UpdateList();
                    }
                    catch (Exception ex)
                    {
                        await Core.Bot.LogForm($"{ex.Message}");
                    }

                }
            }
        }

        private async void BtnEnable_Click(object sender, EventArgs e)
        {
            if (!(LstRoles.SelectedItem is SocketRole curRole)) return;

            // Convertir el permiso seleccionado de string a GuildPermission
            var selectedPermission = (GuildPermission)Enum.Parse(typeof(GuildPermission), LstPermI.SelectedItem.ToString());

            // Crear una nueva lista de permisos desactivando el seleccionado
            var newPermissions = new GuildPermissions(curRole.Permissions.RawValue | (ulong)selectedPermission);

            try
            {
                // Aplicar los cambios al rol
                await curRole.ModifyAsync(properties =>
                {
                    properties.Permissions = newPermissions;
                });

                // Actualizar la lista de permisos en la UI
                UpdateList();

            }
            catch (Exception ex)
            {

                await Core.Bot.LogForm($"{ex.Message}");
            }
        }
        string NL => Environment.NewLine;

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (LstRoles.SelectedIndex <= -1 ) return;
            string r = "";

            foreach (var item in (Enum.GetNames(typeof(GuildPermission)).ToList()))
            {
                var selectedPermission = (GuildPermission)Enum.Parse(typeof(GuildPermission), item);
                if (LstPermA.Items.Contains(selectedPermission))
                {
                    r += $"{item} = true{NL}";
                }
                else
                {
                    r += $"{item} = false{NL}";
                }

            }

            Clipboard.SetText(r);
        }
    }
}

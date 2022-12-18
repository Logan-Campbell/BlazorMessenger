using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LANMessenger.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddExampleMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Date", "RecieverId", "SenderId", "message", "sender_device", "sender_ip" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 26, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 1, 100, "First.", "Windows", "127.0.0.1" },
                    { 2, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 28, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 1, 101, "Second.", "Mac", "127.0.0.1" },
                    { 3, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 34, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4966161043935199636", "Windows", "127.0.0.1" },
                    { 4, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 35, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "76524692519443771", "Mac", "127.0.0.1" },
                    { 5, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 43, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3836376283494827321", "Windows", "127.0.0.1" },
                    { 6, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 44, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "4166358840490870201", "Mac", "127.0.0.1" },
                    { 7, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 47, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "3231934621484814629", "Mac", "127.0.0.1" },
                    { 8, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 49, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "5100876043505245870", "Mac", "127.0.0.1" },
                    { 9, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 56, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7746359910512314579", "Windows", "127.0.0.1" },
                    { 10, new DateTimeOffset(new DateTime(2022, 12, 11, 16, 59, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3156516082253003841", "Windows", "127.0.0.1" },
                    { 11, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 4, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "4162382436572423518", "Mac", "127.0.0.1" },
                    { 12, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 8, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7676295163492442888", "Mac", "127.0.0.1" },
                    { 13, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 9, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "941392144386355100", "Mac", "127.0.0.1" },
                    { 14, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 17, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "6185300879579129257", "Mac", "127.0.0.1" },
                    { 15, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 20, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "3181070178333011145", "Mac", "127.0.0.1" },
                    { 16, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 28, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5229512612046625839", "Windows", "127.0.0.1" },
                    { 17, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 30, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3414535405314083007", "Windows", "127.0.0.1" },
                    { 18, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 34, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "3075375602587502898", "Mac", "127.0.0.1" },
                    { 19, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 40, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1055932406164165938", "Windows", "127.0.0.1" },
                    { 20, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 48, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4417572449278832177", "Windows", "127.0.0.1" },
                    { 21, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 49, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1134539498507555655", "Windows", "127.0.0.1" },
                    { 22, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 50, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "9157593761516003537", "Mac", "127.0.0.1" },
                    { 23, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 53, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "174078785092331039", "Mac", "127.0.0.1" },
                    { 24, new DateTimeOffset(new DateTime(2022, 12, 11, 17, 59, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "8436764473004508510", "Mac", "127.0.0.1" },
                    { 25, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 5, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1883020823407453282", "Windows", "127.0.0.1" },
                    { 26, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 7, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6512576950847069113", "Windows", "127.0.0.1" },
                    { 27, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 9, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "2814992332515081389", "Mac", "127.0.0.1" },
                    { 28, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 14, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "6547510441204069367", "Mac", "127.0.0.1" },
                    { 29, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 20, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2079655379573397991", "Windows", "127.0.0.1" },
                    { 30, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 26, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7134343311073434793", "Mac", "127.0.0.1" },
                    { 31, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 28, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3211719264202379014", "Windows", "127.0.0.1" },
                    { 32, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 34, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "586548738591769647", "Windows", "127.0.0.1" },
                    { 33, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 37, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "59981682369587506", "Windows", "127.0.0.1" },
                    { 34, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 38, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8634920987142083908", "Windows", "127.0.0.1" },
                    { 35, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 46, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "3611988559879665079", "Mac", "127.0.0.1" },
                    { 36, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 51, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6042136682847204288", "Windows", "127.0.0.1" },
                    { 37, new DateTimeOffset(new DateTime(2022, 12, 11, 18, 58, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7549242112227022678", "Mac", "127.0.0.1" },
                    { 38, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 0, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6619241028954246256", "Windows", "127.0.0.1" },
                    { 39, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 8, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "9000435366161245452", "Mac", "127.0.0.1" },
                    { 40, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 16, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8360678038757702406", "Windows", "127.0.0.1" },
                    { 41, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 17, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7415098890349809779", "Windows", "127.0.0.1" },
                    { 42, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 26, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7618506288759683843", "Windows", "127.0.0.1" },
                    { 43, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 27, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6391096482482971308", "Windows", "127.0.0.1" },
                    { 44, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 33, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "641029397182766122", "Windows", "127.0.0.1" },
                    { 45, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 39, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "8567652880785250970", "Mac", "127.0.0.1" },
                    { 46, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 41, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3172696386681258811", "Windows", "127.0.0.1" },
                    { 47, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 48, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6138073218705526531", "Windows", "127.0.0.1" },
                    { 48, new DateTimeOffset(new DateTime(2022, 12, 11, 19, 57, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "584763062371816533", "Mac", "127.0.0.1" },
                    { 49, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 1, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "1910036290222102726", "Mac", "127.0.0.1" },
                    { 50, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 5, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "2398630175975551523", "Mac", "127.0.0.1" },
                    { 51, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 13, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4684180599945440851", "Windows", "127.0.0.1" },
                    { 52, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 18, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "1100917436728704855", "Mac", "127.0.0.1" },
                    { 53, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 20, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8552604446476423508", "Windows", "127.0.0.1" },
                    { 54, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 26, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "199156953499867160", "Mac", "127.0.0.1" },
                    { 55, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 30, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7422058778575462200", "Windows", "127.0.0.1" },
                    { 56, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 31, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8529658912472004961", "Windows", "127.0.0.1" },
                    { 57, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 39, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7053037778610933956", "Windows", "127.0.0.1" },
                    { 58, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 48, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7825229356323762489", "Windows", "127.0.0.1" },
                    { 59, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 50, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "501579034720601947", "Windows", "127.0.0.1" },
                    { 60, new DateTimeOffset(new DateTime(2022, 12, 11, 20, 56, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2954169654887816778", "Windows", "127.0.0.1" },
                    { 61, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 3, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3340126790568353808", "Windows", "127.0.0.1" },
                    { 62, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 4, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4494447984421440716", "Windows", "127.0.0.1" },
                    { 63, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 10, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8662290270270460684", "Windows", "127.0.0.1" },
                    { 64, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 15, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "284358689546728542", "Windows", "127.0.0.1" },
                    { 65, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 20, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "5917104151839383926", "Mac", "127.0.0.1" },
                    { 66, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 22, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "1926378424463185660", "Mac", "127.0.0.1" },
                    { 67, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 31, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "336639508049634824", "Windows", "127.0.0.1" },
                    { 68, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 35, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "822826740916189936", "Windows", "127.0.0.1" },
                    { 69, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 38, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "3567991256599908836", "Mac", "127.0.0.1" },
                    { 70, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 40, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1496395935624863876", "Windows", "127.0.0.1" },
                    { 71, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 44, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8259009425540025076", "Windows", "127.0.0.1" },
                    { 72, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 50, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "477057111023860935", "Mac", "127.0.0.1" },
                    { 73, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 54, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5896576129611080285", "Windows", "127.0.0.1" },
                    { 74, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 57, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1721796666981816760", "Windows", "127.0.0.1" },
                    { 75, new DateTimeOffset(new DateTime(2022, 12, 11, 21, 58, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "5630333428654461270", "Mac", "127.0.0.1" },
                    { 76, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 0, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7075752741173240214", "Windows", "127.0.0.1" },
                    { 77, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 3, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "6155741003865749378", "Mac", "127.0.0.1" },
                    { 78, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 5, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "6859132462229286215", "Mac", "127.0.0.1" },
                    { 79, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 9, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7270374635893113451", "Mac", "127.0.0.1" },
                    { 80, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 15, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2904877513882022627", "Windows", "127.0.0.1" },
                    { 81, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 17, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "4590512068758529200", "Mac", "127.0.0.1" },
                    { 82, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 24, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "719747174105582592", "Mac", "127.0.0.1" },
                    { 83, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 26, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "688210427526550941", "Windows", "127.0.0.1" },
                    { 84, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 32, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8509695691014033426", "Windows", "127.0.0.1" },
                    { 85, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 39, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8034359927032708762", "Windows", "127.0.0.1" },
                    { 86, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 48, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5964517006988751487", "Windows", "127.0.0.1" },
                    { 87, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 52, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "3399257539209859464", "Mac", "127.0.0.1" },
                    { 88, new DateTimeOffset(new DateTime(2022, 12, 11, 22, 53, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5151495658050979288", "Windows", "127.0.0.1" },
                    { 89, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 2, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2441927846521706131", "Windows", "127.0.0.1" },
                    { 90, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 9, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7880382597892811235", "Mac", "127.0.0.1" },
                    { 91, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 12, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1873359396407951873", "Windows", "127.0.0.1" },
                    { 92, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 17, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1868856016294929114", "Windows", "127.0.0.1" },
                    { 93, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 19, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "8759920808005217442", "Mac", "127.0.0.1" },
                    { 94, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 25, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "5328022423691825701", "Mac", "127.0.0.1" },
                    { 95, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 26, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "906594383929845335", "Mac", "127.0.0.1" },
                    { 96, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 33, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5190923540609374853", "Windows", "127.0.0.1" },
                    { 97, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 42, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "8904999351019801982", "Mac", "127.0.0.1" },
                    { 98, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 44, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "6032951391567426840", "Mac", "127.0.0.1" },
                    { 99, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 51, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1043168447825035872", "Windows", "127.0.0.1" },
                    { 100, new DateTimeOffset(new DateTime(2022, 12, 11, 23, 55, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "460963214550774528", "Windows", "127.0.0.1" },
                    { 101, new DateTimeOffset(new DateTime(2022, 12, 12, 0, 2, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "2802442745798641881", "Mac", "127.0.0.1" },
                    { 102, new DateTimeOffset(new DateTime(2022, 12, 12, 0, 5, 2, 66, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "112572277542470420", "Windows", "127.0.0.1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 102);
        }
    }
}

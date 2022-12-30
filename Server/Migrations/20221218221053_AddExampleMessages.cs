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
                    { 1, new DateTimeOffset(new DateTime(2022, 12, 18, 7, 35, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 1, 100, "First.", "Windows", "127.0.0.1" },
                    { 2, new DateTimeOffset(new DateTime(2022, 12, 18, 7, 37, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 1, 101, "Second.", "Mac", "127.0.0.1" },
                    { 4, new DateTimeOffset(new DateTime(2022, 12, 18, 7, 43, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "1900321642248704932", "Mac", "127.0.0.1" },
                    { 5, new DateTimeOffset(new DateTime(2022, 12, 18, 7, 52, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "2524478499898402386", "Mac", "127.0.0.1" },
                    { 6, new DateTimeOffset(new DateTime(2022, 12, 18, 7, 57, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "9058748489721462462", "Windows", "127.0.0.1" },
                    { 7, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 5, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2901599550064024034", "Windows", "127.0.0.1" },
                    { 8, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 13, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "6455822391881743785", "Mac", "127.0.0.1" },
                    { 9, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 22, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "748103725286293756", "Mac", "127.0.0.1" },
                    { 10, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 27, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5927845316570743406", "Windows", "127.0.0.1" },
                    { 11, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 28, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "8830963753255973168", "Mac", "127.0.0.1" },
                    { 12, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 35, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "8366503040399953536", "Mac", "127.0.0.1" },
                    { 13, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 39, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "2041266618684580212", "Mac", "127.0.0.1" },
                    { 14, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 46, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1797758580184831398", "Windows", "127.0.0.1" },
                    { 15, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 54, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "6269581180230142048", "Mac", "127.0.0.1" },
                    { 16, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 56, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "798561190190819023", "Mac", "127.0.0.1" },
                    { 17, new DateTimeOffset(new DateTime(2022, 12, 18, 8, 58, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "2021648516401896599", "Mac", "127.0.0.1" },
                    { 18, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 3, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7465980554445643485", "Mac", "127.0.0.1" },
                    { 19, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 10, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8348777611806571916", "Windows", "127.0.0.1" },
                    { 20, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 15, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6189215388535967281", "Windows", "127.0.0.1" },
                    { 21, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 23, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7051324583354950911", "Windows", "127.0.0.1" },
                    { 22, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 26, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "3067590500202625704", "Mac", "127.0.0.1" },
                    { 23, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 34, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "631974539106393821", "Windows", "127.0.0.1" },
                    { 24, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 41, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "2041519777388964912", "Mac", "127.0.0.1" },
                    { 25, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 42, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "866799362886127015", "Mac", "127.0.0.1" },
                    { 26, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 43, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4525220010979984398", "Windows", "127.0.0.1" },
                    { 27, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 50, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5701717440593017934", "Windows", "127.0.0.1" },
                    { 28, new DateTimeOffset(new DateTime(2022, 12, 18, 9, 54, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2597733108134131500", "Windows", "127.0.0.1" },
                    { 29, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 3, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "4821423465743492185", "Mac", "127.0.0.1" },
                    { 30, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 8, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2587643942817301170", "Windows", "127.0.0.1" },
                    { 31, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 16, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6846774171560812285", "Windows", "127.0.0.1" },
                    { 32, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 25, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5676142573622931118", "Windows", "127.0.0.1" },
                    { 33, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 32, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "1702010335104482132", "Mac", "127.0.0.1" },
                    { 34, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 35, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "585103517897713757", "Mac", "127.0.0.1" },
                    { 35, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 43, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4762641452969897410", "Windows", "127.0.0.1" },
                    { 36, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 44, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7504616830442433082", "Mac", "127.0.0.1" },
                    { 37, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 50, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "9173073096139190539", "Mac", "127.0.0.1" },
                    { 38, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 51, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1995072495810438922", "Windows", "127.0.0.1" },
                    { 39, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 54, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4160467969545393054", "Windows", "127.0.0.1" },
                    { 40, new DateTimeOffset(new DateTime(2022, 12, 18, 10, 58, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8426738062238293257", "Windows", "127.0.0.1" },
                    { 41, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 3, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "155602829019369469", "Windows", "127.0.0.1" },
                    { 42, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 6, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7122307243476710153", "Mac", "127.0.0.1" },
                    { 43, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 10, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8973306905568948902", "Windows", "127.0.0.1" },
                    { 44, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 12, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8143239769656964684", "Windows", "127.0.0.1" },
                    { 45, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 20, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "9147253747438613253", "Mac", "127.0.0.1" },
                    { 46, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 27, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4579555605070733505", "Windows", "127.0.0.1" },
                    { 47, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 30, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7231815561176018558", "Mac", "127.0.0.1" },
                    { 48, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 36, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3145427058978579892", "Windows", "127.0.0.1" },
                    { 49, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 37, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8228531372849633239", "Windows", "127.0.0.1" },
                    { 50, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 40, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "1806906394174585219", "Mac", "127.0.0.1" },
                    { 51, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 45, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "3403167222046419213", "Mac", "127.0.0.1" },
                    { 52, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 54, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "9070504752272607556", "Windows", "127.0.0.1" },
                    { 53, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 56, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "1760855480614827604", "Mac", "127.0.0.1" },
                    { 54, new DateTimeOffset(new DateTime(2022, 12, 18, 11, 57, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7746033925934773010", "Windows", "127.0.0.1" },
                    { 55, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 3, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7928233868202064759", "Mac", "127.0.0.1" },
                    { 56, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 12, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3140402771327038350", "Windows", "127.0.0.1" },
                    { 57, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 16, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "5616410939052307877", "Mac", "127.0.0.1" },
                    { 58, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 22, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4976414899933524841", "Windows", "127.0.0.1" },
                    { 59, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 23, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3497842671692666561", "Windows", "127.0.0.1" },
                    { 60, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 26, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7652042552985070620", "Mac", "127.0.0.1" },
                    { 61, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 31, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "5102680713187374733", "Mac", "127.0.0.1" },
                    { 62, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 34, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8500266869045436099", "Windows", "127.0.0.1" },
                    { 63, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 36, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "1893479189464796913", "Windows", "127.0.0.1" },
                    { 64, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 41, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "933472022535126649", "Mac", "127.0.0.1" },
                    { 65, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 43, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6476541850719846940", "Windows", "127.0.0.1" },
                    { 66, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 44, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "9162612654489090269", "Mac", "127.0.0.1" },
                    { 67, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 46, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7372063885356503050", "Windows", "127.0.0.1" },
                    { 68, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 49, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2714645353470126694", "Windows", "127.0.0.1" },
                    { 69, new DateTimeOffset(new DateTime(2022, 12, 18, 12, 57, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "1864481023584172548", "Mac", "127.0.0.1" },
                    { 70, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 5, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7787660248488914187", "Mac", "127.0.0.1" },
                    { 71, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 10, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3606102755328507073", "Windows", "127.0.0.1" },
                    { 72, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 16, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8416892853863790473", "Windows", "127.0.0.1" },
                    { 73, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 23, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7371860133630637870", "Windows", "127.0.0.1" },
                    { 74, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 32, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8759130626009899265", "Windows", "127.0.0.1" },
                    { 75, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 37, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2411476944169892533", "Windows", "127.0.0.1" },
                    { 76, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 43, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "6980257135625834216", "Mac", "127.0.0.1" },
                    { 77, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 45, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "5877273279894603779", "Mac", "127.0.0.1" },
                    { 78, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 53, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "3481724424445208991", "Mac", "127.0.0.1" },
                    { 79, new DateTimeOffset(new DateTime(2022, 12, 18, 13, 59, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "9179299504892057465", "Mac", "127.0.0.1" },
                    { 80, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 4, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "9087324205766281896", "Windows", "127.0.0.1" },
                    { 81, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 7, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5288936954218485513", "Windows", "127.0.0.1" },
                    { 82, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 10, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7152940248813779067", "Mac", "127.0.0.1" },
                    { 83, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 17, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "1140221487327195265", "Mac", "127.0.0.1" },
                    { 84, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 23, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "2109327995301221485", "Windows", "127.0.0.1" },
                    { 85, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 24, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3292003648552891886", "Windows", "127.0.0.1" },
                    { 86, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 28, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "942696577262774949", "Mac", "127.0.0.1" },
                    { 87, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 33, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6645046956388790073", "Windows", "127.0.0.1" },
                    { 88, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 34, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "7175773876185643732", "Windows", "127.0.0.1" },
                    { 89, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 41, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5022951430031843590", "Windows", "127.0.0.1" },
                    { 90, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 45, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7521718667919031364", "Mac", "127.0.0.1" },
                    { 91, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 52, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "5391626118686539613", "Mac", "127.0.0.1" },
                    { 92, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 53, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "8909520051870209387", "Mac", "127.0.0.1" },
                    { 93, new DateTimeOffset(new DateTime(2022, 12, 18, 14, 57, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "5908573662117465361", "Windows", "127.0.0.1" },
                    { 94, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 6, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6149854009052868772", "Windows", "127.0.0.1" },
                    { 95, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 15, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "8138954957743590195", "Windows", "127.0.0.1" },
                    { 96, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 19, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "4786754129927740401", "Mac", "127.0.0.1" },
                    { 97, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 24, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "4804737190696079182", "Windows", "127.0.0.1" },
                    { 98, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 27, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "6721101630902280449", "Windows", "127.0.0.1" },
                    { 99, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 32, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 101, 100, "3087737166867831176", "Windows", "127.0.0.1" },
                    { 100, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 39, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "2183918811320999351", "Mac", "127.0.0.1" },
                    { 101, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 45, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "6651119496088940300", "Mac", "127.0.0.1" },
                    { 102, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 46, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "8151700405741803888", "Mac", "127.0.0.1" },
                    { 103, new DateTimeOffset(new DateTime(2022, 12, 18, 15, 49, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 100, 101, "7209688102511804693", "Mac", "127.0.0.1" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "password", "username" },
                values: new object[] { 2, "password", "Anon" });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Date", "RecieverId", "SenderId", "message", "sender_device", "sender_ip" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2022, 12, 18, 7, 39, 20, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)), 1, 2, "Third :)", "Android", "10.0.0.45" });
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

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

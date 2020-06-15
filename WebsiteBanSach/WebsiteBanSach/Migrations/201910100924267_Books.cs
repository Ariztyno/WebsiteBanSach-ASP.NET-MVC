﻿namespace WebsiteBanSach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Books : DbMigration
    {
        public override void Up()
        {
            //Books
            Sql("Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Bánh kem', N'banh-kem', N'<p>vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv</p>', N'018.jpg', CAST(20000.00 AS Decimal(18, 2)), CAST(16000.00 AS Decimal(18, 2)), CAST(196.00 AS Decimal(18, 2)), 5, 6, 1, N'<p>vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv</p>', CAST(N'2019-05-01T10:52:18.860' AS DateTime), N'Admin', CAST(N'2019-05-02T00:36:55.193' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'mmmm', N'mmmm', N'<p>vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv</p>', N'011.jpg', CAST(100000.00 AS Decimal(18, 2)), CAST(80000.00 AS Decimal(18, 2)), CAST(98.00 AS Decimal(18, 2)), 5, 6, 1, N'<p>vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv</p>', CAST(N'2019-05-01T15:47:28.460' AS DateTime), N'Admin', CAST(N'2019-05-01T15:47:28.460' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Môi trường kinh tế', N'moi-truong-kinh-te', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(20000.00 AS Decimal(18, 2)), CAST(16000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 6, 6, 1, N'20cm 14cm 10cm', CAST(N'2019-04-25T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-04-25T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Pháp luật', N'phap-luat', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(30000.00 AS Decimal(18, 2)), CAST(24000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 2, 6, 5, N'20cm 14cm 10cm', CAST(N'2019-04-26T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-04-26T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Streamer toàn tập', N'streamer-toan-tap', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(40000.00 AS Decimal(18, 2)), CAST(32000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 2, 9, 3, N'20cm 14cm 10cm', CAST(N'2019-04-27T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-04-27T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Bí kíp làm nghèo', N'bi-kip-lam-ngheo', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(20000.00 AS Decimal(18, 2)), CAST(16000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 4, 7, 1, N'20cm 14cm 10cm', CAST(N'2019-04-28T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-04-28T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Con mèo cụt đuôi', N'con-meo-cut-duoi', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(30000.00 AS Decimal(18, 2)), CAST(24000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 6, 7, 4, N'20cm 14cm 10cm', CAST(N'2019-04-29T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-04-29T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Con chó màu hồng', N'con-cho-mau-hong', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(40000.00 AS Decimal(18, 2)), CAST(32000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 6, 6, 3, N'20cm 14cm 10cm', CAST(N'2019-04-30T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-04-30T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Tắm trong cám', N'tam-trong-cam', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(50000.00 AS Decimal(18, 2)), CAST(40000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 6, 8, 1, N'20cm 14cm 10cm', CAST(N'2019-05-01T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-01T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Dừa có sọ', N'dua-co-so', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(60000.00 AS Decimal(18, 2)), CAST(48000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 6, 8, 5, N'20cm 14cm 10cm', CAST(N'2019-05-02T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-02T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Bạch Đằng Hutech', N'bach-dang-hutech', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(70000.00 AS Decimal(18, 2)), CAST(56000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 6, 6, 3, N'20cm 14cm 10cm', CAST(N'2019-05-03T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-03T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Khai phá thiên cơ', N'khai-pha-thien-co', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(80000.00 AS Decimal(18, 2)), CAST(64000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 5, 7, 1, N'20cm 14cm 10cm', CAST(N'2019-05-04T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-04T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Em ăn cơm rồi', N'em-an-com-roi', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(90000.00 AS Decimal(18, 2)), CAST(72000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 5, 7, 4, N'20cm 14cm 10cm', CAST(N'2019-05-05T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-05T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'1000 câu chuyện buồn', N'1000-cau chuyen-buon', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(100000.00 AS Decimal(18, 2)), CAST(80000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 5, 10, 3, N'20cm 14cm 10cm', CAST(N'2019-05-06T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-06T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Làm người', N'lam-nguoi', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(110000.00 AS Decimal(18, 2)), CAST(88000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 4, 6, 1, N'20cm 14cm 10cm', CAST(N'2019-05-07T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-07T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Đạo đức 1', N'dao-duc-1', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(120000.00 AS Decimal(18, 2)), CAST(96000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 4, 9, 5, N'20cm 14cm 10cm', CAST(N'2019-05-08T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-08T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Ăn cháo đá bát', N'an-chao-da-bat', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(130000.00 AS Decimal(18, 2)), CAST(104000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 4, 8, 3, N'20cm 14cm 10cm', CAST(N'2019-05-09T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-09T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Rùa tai đỏ', N'rua-tai-do', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(140000.00 AS Decimal(18, 2)), CAST(112000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 2, 6, 1, N'20cm 14cm 10cm', CAST(N'2019-05-10T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-10T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Ký sự mương 14', N'ky-su-muong-14', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(150000.00 AS Decimal(18, 2)), CAST(120000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 2, 7, 4, N'20cm 14cm 10cm', CAST(N'2019-05-11T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-11T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Đất rừng phương đông', N'dat-rung-phuong-name', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(160000.00 AS Decimal(18, 2)), CAST(128000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 2, 8, 3, N'20cm 14cm 10cm', CAST(N'2019-05-12T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-12T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Tôi đi code dạo', N'toi-di-code-dao', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(170000.00 AS Decimal(18, 2)), CAST(136000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 5, 8, 1, N'20cm 14cm 10cm', CAST(N'2019-05-13T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-13T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Anh Lân đi bộ', N'anh-lan-di-bo', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(180000.00 AS Decimal(18, 2)), CAST(144000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 4, 6, 4, N'20cm 14cm 10cm', CAST(N'2019-05-14T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-14T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Mai cồ chắt sơn', N'mai-co-chat-son', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(190000.00 AS Decimal(18, 2)), CAST(152000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 3, 7, 3, N'20cm 14cm 10cm', CAST(N'2019-05-15T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-15T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Định luật cu lông', N'dinh-luat-cu-long', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(200000.00 AS Decimal(18, 2)), CAST(160000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 2, 8, 1, N'20cm 14cm 10cm', CAST(N'2019-05-16T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-16T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                + "Insert into Books (Name,MetaTitle,Description,Image,Price,PromotionPrice,Quantity,CategoryID,AuthorID,PublisherID,Detail,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status,ViewCount) VALUES(N'Phở', N'pho', N'asdfgkkkkkkkkkkahhdwydnnndhwjdjwjdj', N'011.jpg', CAST(210000.00 AS Decimal(18, 2)), CAST(168000.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 2, 6, 5, N'20cm 14cm 10cm', CAST(N'2019-05-17T00:00:00.000' AS DateTime), N'Admin', CAST(N'2019-05-17T00:00:00.000' AS DateTime), N'Admin', 1, 0)"
                );
            //Books end
        }

        public override void Down()
        {
        }
    }
}

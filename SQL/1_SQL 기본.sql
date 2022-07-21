# 날짜 : 2022/07/18
# 이름 : 조광현
# 내용 : SQL 기본 실습하기
# CREATE는 추가 # DROP은 삭제
#줄에 커서두고 ctrl + shift +f9
#실습 1-1
CREATE DATABASE `UserDB`; #데이터 베이스 생성
DROP DATABASE `UserDB`;
#실습 1-2
CREATE TABLE `User1`
(
   `uid` VARCHAR(10), #가변길이 문자열 #넉넉하게 10자리
   `name` VARCHAR(10),
   `hp` CHAR(13), #고정길이 문자열
   `age` INT
); #테이블 만들기

DROP TABLE `User1`


#실습 1-3
INSERT INTO `User1` VALUES ('A101', '조광현', '010-1234-1111', 25);
INSERT INTO `User1` VALUES ('A102', '김춘추', '010-1234-2222', 23);
INSERT INTO `User1` VALUES ('A103', '장보고', '010-1234-3333', 32);
INSERT INTO `User1` (`uid`,`name`,`age`)
             VALUES ('A104', '강감찬',42);
INSERT INTO `User1`SET 
                      `uid` = 'A105', # 맵핑해서 인서트
                      `name` = '이순신', 
                      `hp` = '010-1234-4444';

#실습 1-4
SELECT * FROM `User1`; # 별은 모든컬럼 
SELECT * FROM `User1`WHERE `uid` = 'A101';
SELECT * FROM `User1`WHERE `name` = '김춘추';
SELECT * FROM `User1` WHERE `age` > 30;
SELECT`uid`, `name`, `age`FROM `User1`;
#실습 1-5

UPDATE `User1` SET `hp` = '010-1234-4444' WHERE `uid` = 'A104';
UPDATE `User1` SET `age` = 51 where `uid`='A105';
UPDATE `User1` SET `hp` = '010-1234-1001',`age` = 27 where `uid` = 'A101';

#실습 1-6

DELETE FROM `User1` WHERE `uid` = 'A101';
DELETE FROM `User1` WHERE `uid` = 'A103' AND `age` = 25;
DELETE FROM `User1` WHERE `age` >= 30;



user1
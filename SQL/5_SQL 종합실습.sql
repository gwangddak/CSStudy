# 날짜 :2022/07/20
#이름 : 조광현
#내용 : SQL 종합실습 

#실습 5-1
CREATE DATABASE `SaleDB`;
CREATE USER 'manager'@'%' identified BY '1234';
GRANT ALL PRIVILEGES ON `saleDB`.*TO 'manager'@'%';
FLUSH PRIVILEGES;

DROP TABLE `department`;
DROP TABLE `member`;
DROP TABLE `Sales`;
#실습 5-2
CREATE TABLE `member`
(`uid` VARCHAR(10) PRIMARY KEY,
`name`VARCHAR(10) NOT NULL ,
`hp`CHAR (13) NOT NULL UNIQUE ,
`pos`VARCHAR(10) NOT NULL ,
`dep`TINYINT DEFAULT NULL ,
`rdate`DATETIME NOT NULL
);


CREATE TABLE `Sales`
(`seq` INT AUTO_INCREMENT PRIMARY KEY,
`uid` VARCHAR(10) NOT NULL,
`year` YEAR NOT NULL,
`month` TINYINT DEFAULT NULL,
`sale` INT NOT NULL
);




CREATE TABLE `Department`
(
`depNo`TINYINT NOT NULL,
`name`VARCHAR(10) NOT NULL ,
`tel` CHAR(12) NOT NULL UNIQUE
);



#실습 5-3 


INSERT INTO `member` VALUES('a101','박혁거세','010-1234-1001','부장',101,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a102','김유신','010-1234-1002','차장',101,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a103','김춘추','010-1234-1003','사원',101,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a104','장보고','010-1234-1004','대리',102,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a105','강감찬','010-1234-1005','과장',102,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a106','이성계','010-1234-1006','차장',103,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a107','정철','010-1234-1007','차장',103,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a108','이순신','010-1234-1008','부장',104,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a109','허균','010-1234-1009','부장',104,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a110','정약용','010-1234-1010','사원',105,'2020-11-19 11:39:48');
INSERT INTO `member` VALUES('a111','박지원','010-1234-1011','사원',105,'2020-11-19 11:39:48');


INSERT INTO `Sales` VALUES (NULL,'a101',2018,1,98100);
INSERT INTO `Sales` VALUES (NULL,'a102',2018,1,136000);
INSERT INTO `Sales` VALUES (NULL,'a103',2018,1,80100);
INSERT INTO `Sales` VALUES (NULL,'a104',2018,1,78000);
INSERT INTO `Sales` VALUES (NULL,'a105',2018,1,93000);
INSERT INTO `Sales` VALUES (NULL,'a101',2018,2,23500);
INSERT INTO `Sales` VALUES (NULL,'a102',2018,2,126000);
INSERT INTO `Sales` VALUES (NULL,'a103',2018,2,18500);
INSERT INTO `Sales` VALUES (NULL,'a105',2018,2,19000);
INSERT INTO `Sales` VALUES (NULL,'a106',2018,2,53000);
INSERT INTO `Sales` VALUES (NULL,'a101',2018,1,24000);
INSERT INTO `Sales` VALUES (NULL,'a102',2018,1,109000);
INSERT INTO `Sales` VALUES (NULL,'a103',2018,1,101000);
INSERT INTO `Sales` VALUES (NULL,'a104',2018,1,53500);
INSERT INTO `Sales` VALUES (NULL,'a107',2018,1,24000);
INSERT INTO `Sales` VALUES (NULL,'a102',2018,2,160000);
INSERT INTO `Sales` VALUES (NULL,'a103',2018,2,101000);
INSERT INTO `Sales` VALUES (NULL,'a104',2018,2,43000);
INSERT INTO `Sales` VALUES (NULL,'a105',2018,2,24000);
INSERT INTO `Sales` VALUES (NULL,'a106',2018,2,109000);
INSERT INTO `Sales` VALUES (NULL,'a102',2018,1,201000);
INSERT INTO `Sales` VALUES (NULL,'a104',2018,1,63000);
INSERT INTO `Sales` VALUES (NULL,'a105',2018,1,74000);
INSERT INTO `Sales` VALUES (NULL,'a106',2018,1,122000);
INSERT INTO `Sales` VALUES (NULL,'a107',2018,1,111000);
INSERT INTO `Sales` VALUES (NULL,'a102',2018,2,120000);
INSERT INTO `Sales` VALUES (NULL,'a103',2018,2,93000);
INSERT INTO `Sales` VALUES (NULL,'a104',2018,2,84000);
INSERT INTO `Sales` VALUES (NULL,'a105',2018,2,180000);
INSERT INTO `Sales` VALUES (NULL,'a108',2018,2,76000);



INSERT INTO `Department` VALUES (101,'영업1부','051-512-1001');
INSERT INTO `Department` VALUES (102,'영업2부','051-512-1002');
INSERT INTO `Department` VALUES (103,'영업3부','051-512-1003');
INSERT INTO `Department` VALUES (104,'영업4부','051-512-1004');
INSERT INTO `Department` VALUES (105,'영업5부','051-512-1005');
INSERT INTO `Department` VALUES (106,'영업지원부','051-512-1006');
INSERT INTO `Department` VALUES (107,'인사부','051-512-1007');


#실습 5-4


#실습 5-5 # 오름/ 내림차순으로 정렬 # 0부터 시작하는거 헷갈리지 말기
SELECT * FROM `Sales` ORDER BY `sale`;
SELECT * FROM `Sales` ORDER BY `sale`ASC; # 오름차순
SELECT * FROM `Sales` ORDER BY `sale`DESC; # 내림차순
SELECT * FROM `Member` ORDER BY `name`;
SELECT * FROM `Member` ORDER BY `name`DESC; # 내림차순
SELECT * FROM `Member` ORDER BY `name`ASC; # 오름차순
SELECT * FROM `Sales` WHERE `sale` < 50000 ORDER BY `sale`DESC LIMIT 3; #내림차순중 제일 첫번째부터 3개만 호출
SELECT * FROM `Sales` WHERE `sale` > 50000 ORDER BY `year`,`month`, `sale` DESC; # 내림차순중 년도와 개월 세일 동시에 정렬

#실습 5-6 # 레코드 수를 제한해서 추출
SELECT * FROM Sales LIMIT 3; # sales의 첫번째부터 3번째 까지만 호출
SELECT * FROM sales LIMIT 0,3; # 첫번째부터 3개 호출
SELECT * FROM sales LIMIT 1,3;  # 두번째 부터 3개호출
SELECT * FROM sales LIMIT 4,5; # 5번부터 5개 호출
SELECT * FROM sales ORDER BY `sale` DESC LIMIT 3,5; # DESC를  사용하여 3번째 부터의 내림 차순 \
SELECT * FROM sales WHERE `sale` < 50000 ORDER BY `sale` DESC LIMIT 3; # sale이 50000보다 작고 3개만 출력하며 내림차순 정렬
SELECT * FROM sales WHERE `sale` > 50000 ORDER BY `year` DESC, `month`,`sale` DESC LIMIT 5;
# sale이 50000보다 크고 년도순으로 내림차순 정렬 , 개월과 sale 의 내림차순 리밋5개

#실습 5-7  #칼럼명을 별명으로 사용하기
SELECT SUM(sale) AS `합계` FROM `Sales`; # sales의 합계 구하기
SELECT AVG(sale) AS `평균` FROM `Sales`; # sales의 평균값 구하기
SELECT MAX(sale) AS `최대값` FROM `Sales`; #sales의 최대값 구하기
SELECT MIN(sale) AS `최소값` FROM `Sales`; #sales의 최소값 구하기
SELECT COUNT(sale) AS `갯수` FROM `Sales`; # sales의 갯수 구하기
SELECT COUNT(*) AS `갯수` FROM `Sales`; # sales의 갯수 구하기 (*)
SELECT SUBSTRING(`hp`, 10 ,4) AS '전화번호 끝자리' FROM `member`; # 멤버의 전화번호 끝자리 
INSERT INTO `Member` VALUES ('b101','을지문덕', '010-5555-1234','사장',107,NOW()); # NOW()는 날짜함수 이다.
#실습 5-8 # 그룹별로 추출하기
SELECT * FROM `Sales` GROUP BY `uid`; # uid순으로 정렬하고 추출하기 # 중복되는 uid는 중복호출 안됨
SELECT * FROM `Sales` GROUP BY `year`; # year순으로 정렬하고 추출하기 # 중복되는 year는 중복으로 호출 안됨
SELECT * FROM `Sales` GROUP BY `uid`,`year`; # uid와 year순으로 정렬하고 추출하기  
SELECT `uid`, COUNT(*) AS `건수` FROM `Sales` GROUP BY `uid`; # AS는 별칭을 사용한다는 뜻이다
# 즉 AS사용 건수라는 별칭 사용 from Sales칼럼을. uid 의 건수를 총합하여 카운트를 세어준다,.
SELECT `uid`, SUM(sale) AS `합계` FROM `Sales` GROUP BY `uid`;
# 합계라는 별칭으로 바꾸고 uid를 종합하여 합계를 총합해준다.
SELECT `uid`, AVG(sale) AS `평균` FROM `Sales` GROUP BY `uid`;
# 평균이라는 별칭으로 바꾸고 uid 매출의 평균을 계산한다.

SELECT `uid`,`year`, SUM(sale) AS `합계` FROM `Sales` GROUP BY `uid`,`year`;
# 합계라는 별칭으로 바꾸고 uid와 year를 같이 보여준다
SELECT `uid`,`year`, SUM(sale) AS `합계` FROM `Sales` GROUP BY `uid`,`year` ORDER BY `year` ASC, `합계` DESC;
# 위와 같은 내용이지만 year는 오름차순이고 합계는 내림차순으로 보여준다.
SELECT `uid`,`year`, SUM(sale) AS `합계` FROM `Sales` WHERE `sale` >= 50000 GROUP BY `uid`,`year` ORDER BY `합계` DESC;
# 위와 같지만 sale이 50000보다 큰것만 내림차순으로 보여준다.

#실습 5-9

SELECT `uid`, SUM(sale) AS `합계` FROM `Sales` GROUP BY `uid` HAVING SUM(sale) >= 200000;
# 해빙절을 사용하여 조건문 사용. sale의 값이  200000과 같거나 클때의 값을 출력해주시오
SELECT `uid`,`year`,SUM(sale) AS `합계`
FROM `Sales`
WHERE `sale` >= 100000
GROUP BY `uid`,`year`
HAVING SUM(sale) >= 200000
ORDER BY `합계`DESC;



#실습 5-10  # 두개 이상의 테이블에서 레코드 추출하기 (중복데이터 제외)
DROP TABLE `Sales2`;
CREATE TABLE `Sales2` LIKE `Sales`;
INSERT INTO `Sales2` SELECT * FROM `Sales`;
UPDATE `Sales2` SET `year` = `year` + 3; #sales2 의 년도를 전부 3씩 더한다


SELECT * FROM `Sales` UNION SELECT *FROM `Sales2`;
# sales 와 sales2를 함께 출력한다 
(SELECT * FROM `Sales`) UNION (SELECT *FROM `Sales2`);
#괄호를 사용하지만 위에와 같은 맥락이다  
SELECT `uid`,`year`,`sale` FROM Sales UNION SELECT `uid`,`year`, `sale` FROM Sales2;
# 같은 맥락이지만 uid와 year, sale만 같이 출력을시킨다
SELECT `uid`,`year`,SUM(sale) AS `합계` FROM Sales GROUP BY `uid`,`year` UNION SELECT 
`uid`,`year`,SUM(sale) AS `합계` FROM Sales2 GROUP BY `uid`,`year`ORDER BY `year` ASC, `합계`DESC; 
#합계로 별칭 적용하고  내림차순으로 정렬 

# 실습 5-11 
SELECT a.`seq`,a.`uid`,`sale`,`name`,`pos` FROM `Sales` AS a
JOIN `Member` AS b
ON a.uid = b.uid; # uid와 매칭하여 join 시켜줌 


SELECT a.`seq`,a.`uid`,`sale`,`name`,`pos` FROM `Sales` AS a
JOIN `Member` AS b
USING (`uid`);


SELECT * FROM `Sales` AS a
JOIN `member` AS b ON a.uid = b.uid
JOIN `Department` AS c ON b.dep = c.depNo;
orderdb
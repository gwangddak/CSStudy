# 날짜 : 2022/07/18
# 이름 : 조광현
# 내용 : 교재 2장 테이블에서 데이터 검색

#------------------------------
#4강 Hello World 실행하기
#------------------------------
# 테이블 생성
CREATE TABLE `sample21` (
	`no`	     INT,
	`name`     VARCHAR(10),		
	`birthday` CHAR(10),	
	`address`  VARCHAR(100)
);

# 데이터 저장
INSERT INTO `sample21` VALUES (1,'박준용','1976-10-18','대구광역시 수성구');
INSERT INTO `sample21` VALUES (2,'김재진',null,'대구광역시 동구');
INSERT INTO `sample21` VALUES (3, '홍길동',null,'서울특별시 마포구');

#p53

#------------------------------
#5강 테이블 구조 참조하기
#------------------------------
DESC `sample21`;
#p62

#------------------------------
#6강 검색조건 지정하기
#------------------------------
SELECT `no`,`name` FROM `sample21`;
#p66
SELECT * FROM `sample21`; # 모든 데이터를 추출해서 가져옴
SELECT * FROM `sample21` WHERE `no` =2; #no열의 값이 2인 것만 추출해서 가져옴
#p68
SELECT * FROM `sample21`; # 모든 데이터를 추출해서 가져옴
SELECT *FROM `sample21` WHERE NO<>2; #no열의 값이 2가 아닌것만 추출해서 가져옴 # !=도 사용가능 
#p70
SELECT * FROM `sample21`; # 모든 데이터를 추출해서 가져옴
SELECT * FROM `sample21` WHERE `name` = '박준용'; # name열값이 '박준용'인 행만 검색

#p71
SELECT * FROM `sample21`; # 모든 데이터를 추출해서 가져옴
SELECT * FROM `sample21` WHERE `birthday` = NULL;
#p72
SELECT * FROM `sample21`; # 모든 데이터를 추출해서 가져옴
SELECT * FROM `sample21` WHERE `birthday` IS NULL; # birthday가 널인 행만 추출
#p73

#------------------------------
#7강 조건 조합하기
#------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample24` (
	`no` INT,
	`a` INT,
	`b` INT,
	`c` INT 
);

INSERT INTO `sample24` VALUES (1,1,0,0);
INSERT INTO `sample24` VALUES (2,0,1,0);
INSERT INTO `sample24` VALUES (3,0,0,1);
INSERT INTO `sample24` VALUES (4,2,2,0);
INSERT INTO `sample24` VALUES (5,0,2,2);


SELECT * FROM `sample24`; 
#p76
SELECT * FROM `sample24`;
SELECT * FROM `sample24` WHERE a<>0 AND b<>0; #AND 연산자이다 # a가 0이 아닐때와 b가 0이 아닐때  
#p77
SELECT * FROM `sample24`;
SELECT * FROM `sample24` WHERE a<>0 OR b <> 0; #OR 연산자이다 # a가 0이 아니거나 b가 0이 아닐때
#p78
SELECT * FROM `sample24`;
SELECT * FROM `sample24` WHERE a =1 OR a =2 AND b=1 OR b=2;
#p80
SELECT * FROM `sample24`;
SELECT * FROM `sample24` WHERE NOT (a<>0 OR b <> 0); #!(a<>0 \\ b <> 0) 이런느낌 
#p82

#------------------------------
#8강 패턴 매칭에 의한 검색
#------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample25` (
	`no` INT,
	`text` VARCHAR(255)
);

INSERT INTO `sample25` SET `text` = 'SQL';
INSERT INTO `sample25` SET `text` = 'SQL%';
INSERT INTO `sample25` SET `text` = '%SQL%';

SELECT * FROM `sample25`;
SELECT * FROM `sample25` WHERE text LIKE  'SQL%'; # Like 술어 'SQL%'로 전방일치 확인
#p85
SELECT * FROM `sample25`;
SELECT * FROM `sample25` WHERE text LIKE  '%SQL%';# Like 술어 'SQL%'로 중간 일치 확인 
#p86
SELECT * FROM `sample25`;
SELECT * FROM `sample25` WHERE text LIKE  '%\%%';# Like 술어 TEXT열이 %를 포함하는 행을 검색  # 이스케이프 # 첫%와 맨뒤 %는 임의의 문자열이고 중앙값은 그 자체 문자
#p88
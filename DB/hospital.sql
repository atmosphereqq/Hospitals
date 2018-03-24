SELECT b.project_name AS project,SUM(a.outbound_num) AS outbound_num,SUM(a.outbound_money) AS outbound_money,SUM(a.active_num) AS active_num,SUM(a.signed_num) AS signed_num,SUM(a.signed_money) AS signed_money,
			 SUM(IF(a.day>=20180401,a.signed_money,a.outbound_money)) AS finance_money,MIN(a.day) AS min_date,MAX(a.day) AS max_date
			 FROM %s AS a INNER JOIN %s AS b ON a.goods_id = b.goods_id AND project_name <>
			  WHERE  a.day >= %s AND a.day <= %s
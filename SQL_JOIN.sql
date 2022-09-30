select product_name, category_name 
FROM products P 
LEFT JOIN products_and_categories PC 
ON P.product_id = PC.product_id 
LEFT JOIN categories С
ON PC.category_id = С.category_id;
export class Item {
  id: string;  
  name: string;
  display_name: string;
  description: string;
  post_type: string;

  comments: Comment[];
  tags: Tag[];
}

export class Comment {
  id: string;
  description: string;
  
  sub_comments: SubComment[];
}

export class SubComment {
  id: string;
  description: string;
}

export class Tag {
  id: string;  
  name: string;
  display_name: string;
}


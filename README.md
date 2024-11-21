Building ReadIt! application on GCP. 
=====================================================================

![ReadIt Cloud System](https://raw.githubusercontent.com/rohankodavalla/Readit_App-on-GCP/main/readit.png)



ReadIt Cloud System is a cloud-native, scalable, and resilient e-commerce solution implemented on Google Cloud Platform (GCP). This project demonstrates best practices in data engineering, microservices, and cloud architecture to create a highly available online shopping application.

-------------------------------------------------------------------------------------------------------------------------------------------------

**Features**
- Scalable Microservices: Modular design with services like Catalog, Inventory, Cart, and Orders deployed across various GCP offerings.
- Cloud-Native Data Engineering: Implementation of data storage, processing, and pipeline management using services like Cloud SQL, Cloud Bigtable, and Pub/Sub.
- High Availability and Load Balancing:
   - Cloud Load Balancers ensure efficient traffic distribution.
   - Use of multiple VPCs for secure and isolated network communication.
- Event-Driven Design: Leveraging Eventarc and Pub/Sub for real-time communication between services.
- Secure and Reliable Storage:
   - Secret Manager for sensitive information.
   - Cloud Storage for durable and distributed data storage.
- Comprehensive Monitoring:
   - Cloud Monitoring and Cloud Logging for real-time insights and performance tracking.
 
-------------------------------------------------------------------------------------------------------------------------------------------------

**Architecture Overview**

The project architecture is designed with a focus on scalability, modularity, and high availability. Below is a visual representation of the system:


Key Components:

   1. **IAM**: For secure authentication and authorization.
   2. **Inventory Service**: Built with App Engine for scalable management of product stock.
   3. **Catalog Service**: Hosted on Compute Engine, backed by Cloud SQL for relational database storage.
   4. **Weather API**: Custom API hosted on Compute Engine for personalized user experiences.
   5. **Shopping Cart**: Built with GKE and Cloud Run, ensuring seamless cart management for users.
   6. **Order Processing**:
         - Event-driven system with Pub/Sub for order notifications.
         - Serverless compute with Cloud Functions for real-time order updates.
         - Orders stored in Cloud Bigtable for low-latency, high-throughput access.
   7. **Monitoring & Logging**:
         - Cloud-native tools provide detailed logs and dashboards for observability.
     
-------------------------------------------------------------------------------------------------------------------------------------------------

**Technologies and Tools Used**

**Cloud Services**
- Google Cloud Platform (GCP): App Engine, Compute Engine, Cloud SQL, Cloud Bigtable, Cloud Storage, Cloud Run, Pub/Sub, Eventarc, GKE, Identity Platform, Cloud Monitoring, Cloud Logging.

**Programming and Frameworks**
- Python: For serverless and backend logic.
- JavaScript: Frontend for interactive user experiences.

**Security**
- IAM: User authentication and resource access control.
- Secret Manager: Management of sensitive credentials.
  
**Data Engineering Tools**
- Cloud SQL: Relational database for catalog data.
- Cloud Bigtable: NoSQL database for scalable and low-latency order management.
- Cloud Storage: Durable and highly available file storage.

-------------------------------------------------------------------------------------------------------------------------------------------------

**Use Cases for Data Engineering Roles**
This project highlights critical data engineering practices, including:

   1. ETL Pipelines:
         - Transforming and loading catalog and order data into Cloud SQL and Bigtable.
         - Real-time data streaming with Pub/Sub.
   2. Data Modeling:
         - Relational design for inventory and catalog data.
         - NoSQL schema for optimized read/write performance in order management.
   3. Data Pipeline Automation:
         - Integration of Eventarc and Cloud Functions for automated, event-triggered workflows.
   4. Monitoring and Observability:
         - Implementation of comprehensive monitoring tools to ensure service reliability.

-------------------------------------------------------------------------------------------------------------------------------------------------

**Future Enhancements**
- Add analytics dashboards using BigQuery and Looker Studio.
- Expand support for multi-region deployments for improved disaster recovery.



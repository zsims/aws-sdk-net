/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Route53.Model;
using Amazon.Route53.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53
{
    /// <summary>
    /// Implementation for accessing Route53
    ///
    /// 
    /// </summary>
    public partial class AmazonRoute53Client : AmazonServiceClient, IAmazonRoute53
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRoute53Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config()) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(AmazonRoute53Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53Client(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials and an
        /// AmazonRoute53Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(AWSCredentials credentials, AmazonRoute53Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS3Signer();
        }

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.Route53.Internal.AmazonRoute53PostMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.Route53.Internal.AmazonRoute53PreMarshallHandler());
        }    

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AssociateVPCWithHostedZone

        /// <summary>
        /// This action associates a VPC with an hosted zone. 
        /// 
        ///  
        /// <para>
        ///  To associate a VPC with an hosted zone, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
        /// zone ID</i>/associatevpc</code> resource. The request body must include an XML document
        /// with a <code>AssociateVPCWithHostedZoneRequest</code> element. The response returns
        /// the <code>AssociateVPCWithHostedZoneResponse</code> element that contains <code>ChangeInfo</code>
        /// for you to track the progress of the <code>AssociateVPCWithHostedZoneRequest</code>
        /// you made. See <code>GetChange</code> operation for how to track the progress of your
        /// change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone service method.</param>
        /// 
        /// <returns>The response from the AssociateVPCWithHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Route
        /// 53 returns this error when the VPC specified by <code>VPCId</code> does not belong
        /// to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PublicZoneVPCAssociationException">
        /// The hosted zone you are trying to associate VPC with doesn't have any VPC association.
        /// Route 53 currently doesn't support associate a VPC with a public hosted zone.
        /// </exception>
        public AssociateVPCWithHostedZoneResponse AssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request)
        {
            var marshaller = new AssociateVPCWithHostedZoneRequestMarshaller();
            var unmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return Invoke<AssociateVPCWithHostedZoneRequest,AssociateVPCWithHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVPCWithHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateVPCWithHostedZone
        ///         operation.</returns>
        public IAsyncResult BeginAssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateVPCWithHostedZoneRequestMarshaller();
            var unmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateVPCWithHostedZoneRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateVPCWithHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateVPCWithHostedZone.</param>
        /// 
        /// <returns>Returns a  AssociateVPCWithHostedZoneResult from Route53.</returns>
        public  AssociateVPCWithHostedZoneResponse EndAssociateVPCWithHostedZone(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateVPCWithHostedZoneResponse>(asyncResult);
        }

        #endregion
        
        #region  ChangeResourceRecordSets

        /// <summary>
        /// Use this action to create or change your authoritative DNS information. To use this
        /// action, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
        /// Zone ID</i>/rrset</code> resource. The request body must include an XML document with
        /// a <code>ChangeResourceRecordSetsRequest</code> element.
        /// 
        ///  
        /// <para>
        /// Changes are a list of change items and are considered transactional. For more information
        /// on transactional changes, also known as change batches, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/RRSchanges.html#RRSchanges_API">Creating,
        /// Changing, and Deleting Resource Record Sets Using the Route 53 API</a> in the <i>Amazon
        /// Route 53 Developer Guide</i>.
        /// </para>
        ///  <important>Due to the nature of transactional changes, you cannot delete the same
        /// resource record set more than once in a single change batch. If you attempt to delete
        /// the same change batch more than once, Route 53 returns an <code>InvalidChangeBatch</code>
        /// error.</important> 
        /// <para>
        /// In response to a <code>ChangeResourceRecordSets</code> request, your DNS data is changed
        /// on all Route 53 DNS servers. Initially, the status of a change is <code>PENDING</code>.
        /// This means the change has not yet propagated to all the authoritative Route 53 DNS
        /// servers. When the change is propagated to all hosts, the change returns a status of
        /// <code>INSYNC</code>.
        /// </para>
        ///  
        /// <para>
        /// Note the following limitations on a <code>ChangeResourceRecordSets</code> request:
        /// </para>
        ///  
        /// <para>
        /// - A request cannot contain more than 100 Change elements.
        /// </para>
        ///  
        /// <para>
        /// - A request cannot contain more than 1000 ResourceRecord elements.
        /// </para>
        ///  
        /// <para>
        /// The sum of the number of characters (including spaces) in all <code>Value</code> elements
        /// in a request cannot exceed 32,000 characters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ChangeResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidChangeBatchException">
        /// This error contains a list of one or more error messages. Each error message indicates
        /// one error in the change batch. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/APIReference/API_ChangeResourceRecordSets.html#example_Errors">Example
        /// InvalidChangeBatch Errors</a>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        public ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest request)
        {
            var marshaller = new ChangeResourceRecordSetsRequestMarshaller();
            var unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ChangeResourceRecordSetsRequest,ChangeResourceRecordSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChangeResourceRecordSets
        ///         operation.</returns>
        public IAsyncResult BeginChangeResourceRecordSets(ChangeResourceRecordSetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ChangeResourceRecordSetsRequestMarshaller();
            var unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return BeginInvoke<ChangeResourceRecordSetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ChangeResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeResourceRecordSets.</param>
        /// 
        /// <returns>Returns a  ChangeResourceRecordSetsResult from Route53.</returns>
        public  ChangeResourceRecordSetsResponse EndChangeResourceRecordSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ChangeResourceRecordSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ChangeTagsForResource

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ChangeTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        public ChangeTagsForResourceResponse ChangeTagsForResource(ChangeTagsForResourceRequest request)
        {
            var marshaller = new ChangeTagsForResourceRequestMarshaller();
            var unmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ChangeTagsForResourceRequest,ChangeTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChangeTagsForResource
        ///         operation.</returns>
        public IAsyncResult BeginChangeTagsForResource(ChangeTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ChangeTagsForResourceRequestMarshaller();
            var unmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ChangeTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ChangeTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeTagsForResource.</param>
        /// 
        /// <returns>Returns a  ChangeTagsForResourceResult from Route53.</returns>
        public  ChangeTagsForResourceResponse EndChangeTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ChangeTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHealthCheck

        /// <summary>
        /// This action creates a new health check.
        /// 
        ///  
        /// <para>
        ///  To create a new health check, send a <code>POST</code> request to the <code>2013-04-01/healthcheck</code>
        /// resource. The request body must include an XML document with a <code>CreateHealthCheckRequest</code>
        /// element. The response returns the <code>CreateHealthCheckResponse</code> element that
        /// contains metadata about the health check.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the CreateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckAlreadyExistsException">
        /// The health check you are trying to create already exists. Route 53 returns this error
        /// when a health check has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHealthChecksException">
        /// 
        /// </exception>
        public CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest request)
        {
            var marshaller = new CreateHealthCheckRequestMarshaller();
            var unmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<CreateHealthCheckRequest,CreateHealthCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHealthCheck
        ///         operation.</returns>
        public IAsyncResult BeginCreateHealthCheck(CreateHealthCheckRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateHealthCheckRequestMarshaller();
            var unmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return BeginInvoke<CreateHealthCheckRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHealthCheck.</param>
        /// 
        /// <returns>Returns a  CreateHealthCheckResult from Route53.</returns>
        public  CreateHealthCheckResponse EndCreateHealthCheck(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHealthCheckResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHostedZone

        /// <summary>
        /// This action creates a new hosted zone.
        /// 
        ///  
        /// <para>
        /// To create a new hosted zone, send a <code>POST</code> request to the <code>2013-04-01/hostedzone</code>
        /// resource. The request body must include an XML document with a <code>CreateHostedZoneRequest</code>
        /// element. The response returns the <code>CreateHostedZoneResponse</code> element that
        /// contains metadata about the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Route 53 automatically creates a default SOA record and four NS records for the zone.
        /// The NS records in the hosted zone are the name servers you give your registrar to
        /// delegate your domain to. For more information about SOA and NS records, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html">NS
        /// and SOA Records that Route 53 Creates for a Hosted Zone</a> in the <i>Amazon Route
        /// 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you create a zone, its initial status is <code>PENDING</code>. This means that
        /// it is not yet available on all DNS servers. The status of the zone changes to <code>INSYNC</code>
        /// when the NS and SOA records are available on all Route 53 DNS servers. 
        /// </para>
        ///  
        /// <para>
        /// When trying to create a hosted zone using a reusable delegation set, you could specify
        /// an optional DelegationSetId, and Route53 would assign those 4 NS records for the zone,
        /// instead of alloting a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone service method.</param>
        /// 
        /// <returns>The response from the CreateHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// Route 53 allows some duplicate domain names, but there is a maximum number of duplicate
        /// names. This error indicates that you have reached that maximum. If you want to create
        /// another hosted zone with the same name and Route 53 generates this error, you can
        /// request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneAlreadyExistsException">
        /// The hosted zone you are trying to create already exists. Route 53 returns this error
        /// when a hosted zone has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// This error indicates that the specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Route
        /// 53 returns this error when the VPC specified by <code>VPCId</code> does not belong
        /// to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHostedZonesException">
        /// This error indicates that you've reached the maximum number of hosted zones that can
        /// be created for the current AWS account. You can request an increase to the limit on
        /// the <a href="http://aws.amazon.com/route53-request/">Contact Us</a> page.
        /// </exception>
        public CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest request)
        {
            var marshaller = new CreateHostedZoneRequestMarshaller();
            var unmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return Invoke<CreateHostedZoneRequest,CreateHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHostedZone
        ///         operation.</returns>
        public IAsyncResult BeginCreateHostedZone(CreateHostedZoneRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateHostedZoneRequestMarshaller();
            var unmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return BeginInvoke<CreateHostedZoneRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHostedZone.</param>
        /// 
        /// <returns>Returns a  CreateHostedZoneResult from Route53.</returns>
        public  CreateHostedZoneResponse EndCreateHostedZone(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHostedZoneResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReusableDelegationSet

        /// <summary>
        /// This action creates a reusable delegationSet.
        /// 
        ///  
        /// <para>
        ///  To create a new reusable delegationSet, send a <code>POST</code> request to the <code>2013-04-01/delegationset</code>
        /// resource. The request body must include an XML document with a <code>CreateReusableDelegationSetRequest</code>
        /// element. The response returns the <code>CreateReusableDelegationSetResponse</code>
        /// element that contains metadata about the delegationSet. 
        /// </para>
        ///  
        /// <para>
        ///  If the optional parameter HostedZoneId is specified, it marks the delegationSet associated
        /// with that particular hosted zone as reusable. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the CreateReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetAlreadyCreatedException">
        /// A delegation set with the same owner and caller reference combination has already
        /// been created.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetAlreadyReusableException">
        /// The specified delegation set has already been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// Route 53 allows some duplicate domain names, but there is a maximum number of duplicate
        /// names. This error indicates that you have reached that maximum. If you want to create
        /// another hosted zone with the same name and Route 53 generates this error, you can
        /// request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotFoundException">
        /// The specified HostedZone cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// At least one of the specified arguments is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// The limits specified for a resource have been exceeded.
        /// </exception>
        public CreateReusableDelegationSetResponse CreateReusableDelegationSet(CreateReusableDelegationSetRequest request)
        {
            var marshaller = new CreateReusableDelegationSetRequestMarshaller();
            var unmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<CreateReusableDelegationSetRequest,CreateReusableDelegationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReusableDelegationSet
        ///         operation.</returns>
        public IAsyncResult BeginCreateReusableDelegationSet(CreateReusableDelegationSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateReusableDelegationSetRequestMarshaller();
            var unmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateReusableDelegationSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReusableDelegationSet.</param>
        /// 
        /// <returns>Returns a  CreateReusableDelegationSetResult from Route53.</returns>
        public  CreateReusableDelegationSetResponse EndCreateReusableDelegationSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReusableDelegationSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHealthCheck

        /// <summary>
        /// This action deletes a health check. To delete a health check, send a <code>DELETE</code>
        /// request to the <code>2013-04-01/healthcheck/<i>health check ID</i></code> resource.
        /// 
        ///  <important> You can delete a health check only if there are no resource record sets
        /// associated with this health check. If resource record sets are associated with this
        /// health check, you must disassociate them before you can delete your health check.
        /// If you try to delete a health check that is associated with resource record sets,
        /// Route 53 will deny your request with a <code>HealthCheckInUse</code> error. For information
        /// about disassociating the records from your health check, see <a>ChangeResourceRecordSets</a>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck service method.</param>
        /// 
        /// <returns>The response from the DeleteHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckInUseException">
        /// There are resource records associated with this health check. Before you can delete
        /// the health check, you must disassociate it from the resource record sets.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest request)
        {
            var marshaller = new DeleteHealthCheckRequestMarshaller();
            var unmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return Invoke<DeleteHealthCheckRequest,DeleteHealthCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHealthCheck
        ///         operation.</returns>
        public IAsyncResult BeginDeleteHealthCheck(DeleteHealthCheckRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteHealthCheckRequestMarshaller();
            var unmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteHealthCheckRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHealthCheck.</param>
        /// 
        /// <returns>Returns a  DeleteHealthCheckResult from Route53.</returns>
        public  DeleteHealthCheckResponse EndDeleteHealthCheck(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHealthCheckResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHostedZone

        /// <summary>
        /// This action deletes a hosted zone. To delete a hosted zone, send a <code>DELETE</code>
        /// request to the <code>2013-04-01/hostedzone/<i>hosted zone ID</i></code> resource.
        /// 
        ///  
        /// <para>
        /// For more information about deleting a hosted zone, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DeleteHostedZone.html">Deleting
        /// a Hosted Zone</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  <important> You can delete a hosted zone only if there are no resource record sets
        /// other than the default SOA record and NS resource record sets. If your hosted zone
        /// contains other resource record sets, you must delete them before you can delete your
        /// hosted zone. If you try to delete a hosted zone that contains other resource record
        /// sets, Route 53 will deny your request with a <code>HostedZoneNotEmpty</code> error.
        /// For information about deleting records from your hosted zone, see <a>ChangeResourceRecordSets</a>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone service method.</param>
        /// 
        /// <returns>The response from the DeleteHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotEmptyException">
        /// The hosted zone contains resource record sets in addition to the default NS and SOA
        /// resource record sets. Before you can delete the hosted zone, you must delete the additional
        /// resource record sets.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        public DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest request)
        {
            var marshaller = new DeleteHostedZoneRequestMarshaller();
            var unmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DeleteHostedZoneRequest,DeleteHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHostedZone
        ///         operation.</returns>
        public IAsyncResult BeginDeleteHostedZone(DeleteHostedZoneRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteHostedZoneRequestMarshaller();
            var unmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteHostedZoneRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHostedZone.</param>
        /// 
        /// <returns>Returns a  DeleteHostedZoneResult from Route53.</returns>
        public  DeleteHostedZoneResponse EndDeleteHostedZone(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHostedZoneResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReusableDelegationSet

        /// <summary>
        /// This action deletes a reusable delegation set. To delete a reusable delegation set,
        /// send a <code>DELETE</code> request to the <code>2013-04-01/delegationset/<i>delegation
        /// set ID</i></code> resource.
        /// 
        ///  <important> You can delete a reusable delegation set only if there are no associated
        /// hosted zones. If your reusable delegation set contains associated hosted zones, you
        /// must delete them before you can delete your reusable delegation set. If you try to
        /// delete a reusable delegation set that contains associated hosted zones, Route 53 will
        /// deny your request with a <code>DelegationSetInUse</code> error.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetInUseException">
        /// The specified delegation contains associated hosted zones which must be deleted before
        /// the reusable delegation set can be deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        public DeleteReusableDelegationSetResponse DeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request)
        {
            var marshaller = new DeleteReusableDelegationSetRequestMarshaller();
            var unmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteReusableDelegationSetRequest,DeleteReusableDelegationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReusableDelegationSet
        ///         operation.</returns>
        public IAsyncResult BeginDeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteReusableDelegationSetRequestMarshaller();
            var unmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteReusableDelegationSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReusableDelegationSet.</param>
        /// 
        /// <returns>Returns a  DeleteReusableDelegationSetResult from Route53.</returns>
        public  DeleteReusableDelegationSetResponse EndDeleteReusableDelegationSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReusableDelegationSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateVPCFromHostedZone

        /// <summary>
        /// This action disassociates a VPC from an hosted zone. 
        /// 
        ///  
        /// <para>
        ///  To disassociate a VPC to a hosted zone, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
        /// zone ID</i>/disassociatevpc</code> resource. The request body must include an XML
        /// document with a <code>DisassociateVPCFromHostedZoneRequest</code> element. The response
        /// returns the <code>DisassociateVPCFromHostedZoneResponse</code> element that contains
        /// <code>ChangeInfo</code> for you to track the progress of the <code>DisassociateVPCFromHostedZoneRequest</code>
        /// you made. See <code>GetChange</code> operation for how to track the progress of your
        /// change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone service method.</param>
        /// 
        /// <returns>The response from the DisassociateVPCFromHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Route
        /// 53 returns this error when the VPC specified by <code>VPCId</code> does not belong
        /// to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LastVPCAssociationException">
        /// The VPC you are trying to disassociate from the hosted zone is the last the VPC that
        /// is associated with the hosted zone. Route 53 currently doesn't support disassociate
        /// the last VPC from the hosted zone.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.VPCAssociationNotFoundException">
        /// The VPC you specified is not currently associated with the hosted zone.
        /// </exception>
        public DisassociateVPCFromHostedZoneResponse DisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request)
        {
            var marshaller = new DisassociateVPCFromHostedZoneRequestMarshaller();
            var unmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DisassociateVPCFromHostedZoneRequest,DisassociateVPCFromHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVPCFromHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateVPCFromHostedZone
        ///         operation.</returns>
        public IAsyncResult BeginDisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateVPCFromHostedZoneRequestMarshaller();
            var unmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateVPCFromHostedZoneRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateVPCFromHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateVPCFromHostedZone.</param>
        /// 
        /// <returns>Returns a  DisassociateVPCFromHostedZoneResult from Route53.</returns>
        public  DisassociateVPCFromHostedZoneResponse EndDisassociateVPCFromHostedZone(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateVPCFromHostedZoneResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChange

        /// <summary>
        /// This action returns the current status of a change batch request. The status is one
        /// of the following values:
        /// 
        ///  
        /// <para>
        /// - <code>PENDING</code> indicates that the changes in this request have not replicated
        /// to all Route 53 DNS servers. This is the initial status of all change batch requests.
        /// </para>
        ///  
        /// <para>
        /// - <code>INSYNC</code> indicates that the changes have replicated to all Amazon Route
        /// 53 DNS servers. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChange service method.</param>
        /// 
        /// <returns>The response from the GetChange service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchChangeException">
        /// 
        /// </exception>
        public GetChangeResponse GetChange(GetChangeRequest request)
        {
            var marshaller = new GetChangeRequestMarshaller();
            var unmarshaller = GetChangeResponseUnmarshaller.Instance;

            return Invoke<GetChangeRequest,GetChangeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChange operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChange
        ///         operation.</returns>
        public IAsyncResult BeginGetChange(GetChangeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetChangeRequestMarshaller();
            var unmarshaller = GetChangeResponseUnmarshaller.Instance;

            return BeginInvoke<GetChangeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChange operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChange.</param>
        /// 
        /// <returns>Returns a  GetChangeResult from Route53.</returns>
        public  GetChangeResponse EndGetChange(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChangeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCheckerIpRanges

        /// <summary>
        /// To retrieve a list of the IP ranges used by Amazon Route 53 health checkers to check
        /// the health of your resources, send a <code>GET</code> request to the <code>2013-04-01/checkeripranges</code>
        /// resource. You can use these IP addresses to configure router and firewall rules to
        /// allow health checkers to check the health of your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges service method.</param>
        /// 
        /// <returns>The response from the GetCheckerIpRanges service method, as returned by Route53.</returns>
        public GetCheckerIpRangesResponse GetCheckerIpRanges(GetCheckerIpRangesRequest request)
        {
            var marshaller = new GetCheckerIpRangesRequestMarshaller();
            var unmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return Invoke<GetCheckerIpRangesRequest,GetCheckerIpRangesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCheckerIpRanges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCheckerIpRanges
        ///         operation.</returns>
        public IAsyncResult BeginGetCheckerIpRanges(GetCheckerIpRangesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetCheckerIpRangesRequestMarshaller();
            var unmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return BeginInvoke<GetCheckerIpRangesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCheckerIpRanges operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCheckerIpRanges.</param>
        /// 
        /// <returns>Returns a  GetCheckerIpRangesResult from Route53.</returns>
        public  GetCheckerIpRangesResponse EndGetCheckerIpRanges(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCheckerIpRangesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGeoLocation

        /// <summary>
        /// To retrieve a single geo location, send a <code>GET</code> request to the <code>2013-04-01/geolocation</code>
        /// resource with one of these options: continentcode | countrycode | countrycode and
        /// subdivisioncode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation service method.</param>
        /// 
        /// <returns>The response from the GetGeoLocation service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchGeoLocationException">
        /// The geo location you are trying to get does not exist.
        /// </exception>
        public GetGeoLocationResponse GetGeoLocation(GetGeoLocationRequest request)
        {
            var marshaller = new GetGeoLocationRequestMarshaller();
            var unmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return Invoke<GetGeoLocationRequest,GetGeoLocationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeoLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGeoLocation
        ///         operation.</returns>
        public IAsyncResult BeginGetGeoLocation(GetGeoLocationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetGeoLocationRequestMarshaller();
            var unmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return BeginInvoke<GetGeoLocationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGeoLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGeoLocation.</param>
        /// 
        /// <returns>Returns a  GetGeoLocationResult from Route53.</returns>
        public  GetGeoLocationResponse EndGetGeoLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGeoLocationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetHealthCheck

        /// <summary>
        /// To retrieve the health check, send a <code>GET</code> request to the <code>2013-04-01/healthcheck/<i>health
        /// check ID</i></code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Route 53 endpoint. Please
        /// consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public GetHealthCheckResponse GetHealthCheck(GetHealthCheckRequest request)
        {
            var marshaller = new GetHealthCheckRequestMarshaller();
            var unmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckRequest,GetHealthCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthCheck
        ///         operation.</returns>
        public IAsyncResult BeginGetHealthCheck(GetHealthCheckRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetHealthCheckRequestMarshaller();
            var unmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return BeginInvoke<GetHealthCheckRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthCheck.</param>
        /// 
        /// <returns>Returns a  GetHealthCheckResult from Route53.</returns>
        public  GetHealthCheckResponse EndGetHealthCheck(IAsyncResult asyncResult)
        {
            return EndInvoke<GetHealthCheckResponse>(asyncResult);
        }

        #endregion
        
        #region  GetHealthCheckCount

        /// <summary>
        /// To retrieve a count of all your health checks, send a <code>GET</code> request to
        /// the <code>2013-04-01/healthcheckcount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckCount service method, as returned by Route53.</returns>
        public GetHealthCheckCountResponse GetHealthCheckCount(GetHealthCheckCountRequest request)
        {
            var marshaller = new GetHealthCheckCountRequestMarshaller();
            var unmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckCountRequest,GetHealthCheckCountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthCheckCount
        ///         operation.</returns>
        public IAsyncResult BeginGetHealthCheckCount(GetHealthCheckCountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetHealthCheckCountRequestMarshaller();
            var unmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return BeginInvoke<GetHealthCheckCountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetHealthCheckCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthCheckCount.</param>
        /// 
        /// <returns>Returns a  GetHealthCheckCountResult from Route53.</returns>
        public  GetHealthCheckCountResponse EndGetHealthCheckCount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetHealthCheckCountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetHealthCheckLastFailureReason

        /// <summary>
        /// If you want to learn why a health check is currently failing or why it failed most
        /// recently (if at all), you can get the failure reason for the most recent failure.
        /// Send a <code>GET</code> request to the <code>2013-04-01/healthcheck/<i>health check
        /// ID</i>/lastfailurereason</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckLastFailureReason service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public GetHealthCheckLastFailureReasonResponse GetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request)
        {
            var marshaller = new GetHealthCheckLastFailureReasonRequestMarshaller();
            var unmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckLastFailureReasonRequest,GetHealthCheckLastFailureReasonResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckLastFailureReason operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthCheckLastFailureReason
        ///         operation.</returns>
        public IAsyncResult BeginGetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetHealthCheckLastFailureReasonRequestMarshaller();
            var unmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return BeginInvoke<GetHealthCheckLastFailureReasonRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetHealthCheckLastFailureReason operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthCheckLastFailureReason.</param>
        /// 
        /// <returns>Returns a  GetHealthCheckLastFailureReasonResult from Route53.</returns>
        public  GetHealthCheckLastFailureReasonResponse EndGetHealthCheckLastFailureReason(IAsyncResult asyncResult)
        {
            return EndInvoke<GetHealthCheckLastFailureReasonResponse>(asyncResult);
        }

        #endregion
        
        #region  GetHealthCheckStatus

        /// <summary>
        /// To retrieve the health check status, send a <code>GET</code> request to the <code>2013-04-01/healthcheck/<i>health
        /// check ID</i>/status</code> resource. You can use this call to get a health check's
        /// current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckStatus service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public GetHealthCheckStatusResponse GetHealthCheckStatus(GetHealthCheckStatusRequest request)
        {
            var marshaller = new GetHealthCheckStatusRequestMarshaller();
            var unmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckStatusRequest,GetHealthCheckStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthCheckStatus
        ///         operation.</returns>
        public IAsyncResult BeginGetHealthCheckStatus(GetHealthCheckStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetHealthCheckStatusRequestMarshaller();
            var unmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return BeginInvoke<GetHealthCheckStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetHealthCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthCheckStatus.</param>
        /// 
        /// <returns>Returns a  GetHealthCheckStatusResult from Route53.</returns>
        public  GetHealthCheckStatusResponse EndGetHealthCheckStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetHealthCheckStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetHostedZone

        /// <summary>
        /// To retrieve the delegation set for a hosted zone, send a <code>GET</code> request
        /// to the <code>2013-04-01/hostedzone/<i>hosted zone ID</i></code> resource. The delegation
        /// set is the four Route 53 name servers that were assigned to the hosted zone when you
        /// created it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone service method.</param>
        /// 
        /// <returns>The response from the GetHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        public GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest request)
        {
            var marshaller = new GetHostedZoneRequestMarshaller();
            var unmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneRequest,GetHostedZoneResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostedZone
        ///         operation.</returns>
        public IAsyncResult BeginGetHostedZone(GetHostedZoneRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetHostedZoneRequestMarshaller();
            var unmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return BeginInvoke<GetHostedZoneRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostedZone.</param>
        /// 
        /// <returns>Returns a  GetHostedZoneResult from Route53.</returns>
        public  GetHostedZoneResponse EndGetHostedZone(IAsyncResult asyncResult)
        {
            return EndInvoke<GetHostedZoneResponse>(asyncResult);
        }

        #endregion
        
        #region  GetHostedZoneCount

        /// <summary>
        /// To retrieve a count of all your hosted zones, send a <code>GET</code> request to
        /// the <code>2013-04-01/hostedzonecount</code> resource.
        /// </summary>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public GetHostedZoneCountResponse GetHostedZoneCount()
        {
            return GetHostedZoneCount(new GetHostedZoneCountRequest());
        }

        /// <summary>
        /// To retrieve a count of all your hosted zones, send a <code>GET</code> request to
        /// the <code>2013-04-01/hostedzonecount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount service method.</param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public GetHostedZoneCountResponse GetHostedZoneCount(GetHostedZoneCountRequest request)
        {
            var marshaller = new GetHostedZoneCountRequestMarshaller();
            var unmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneCountRequest,GetHostedZoneCountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZoneCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostedZoneCount
        ///         operation.</returns>
        public IAsyncResult BeginGetHostedZoneCount(GetHostedZoneCountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetHostedZoneCountRequestMarshaller();
            var unmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return BeginInvoke<GetHostedZoneCountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostedZoneCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostedZoneCount.</param>
        /// 
        /// <returns>Returns a  GetHostedZoneCountResult from Route53.</returns>
        public  GetHostedZoneCountResponse EndGetHostedZoneCount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetHostedZoneCountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReusableDelegationSet

        /// <summary>
        /// To retrieve the reusable delegation set, send a <code>GET</code> request to the <code>2013-04-01/delegationset/<i>delegation
        /// set ID</i></code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the GetReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        public GetReusableDelegationSetResponse GetReusableDelegationSet(GetReusableDelegationSetRequest request)
        {
            var marshaller = new GetReusableDelegationSetRequestMarshaller();
            var unmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<GetReusableDelegationSetRequest,GetReusableDelegationSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReusableDelegationSet
        ///         operation.</returns>
        public IAsyncResult BeginGetReusableDelegationSet(GetReusableDelegationSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetReusableDelegationSetRequestMarshaller();
            var unmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return BeginInvoke<GetReusableDelegationSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReusableDelegationSet.</param>
        /// 
        /// <returns>Returns a  GetReusableDelegationSetResult from Route53.</returns>
        public  GetReusableDelegationSetResponse EndGetReusableDelegationSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReusableDelegationSetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGeoLocations

        /// <summary>
        /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
        /// the <code>2013-04-01/geolocations</code> resource. The response to this request includes
        /// a <code>GeoLocationDetailsList</code> element with zero, one, or multiple <code>GeoLocationDetails</code>
        /// child elements. The list is sorted by country code, and then subdivision code, followed
        /// by continents at the end of the list. 
        /// 
        ///  
        /// <para>
        ///  By default, the list of geo locations is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
        /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
        /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
        /// StartSubdivisionCode</code> to control the geo location that the list begins with.
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListGeoLocationsResponse ListGeoLocations()
        {
            return ListGeoLocations(new ListGeoLocationsRequest());
        }

        /// <summary>
        /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
        /// the <code>2013-04-01/geolocations</code> resource. The response to this request includes
        /// a <code>GeoLocationDetailsList</code> element with zero, one, or multiple <code>GeoLocationDetails</code>
        /// child elements. The list is sorted by country code, and then subdivision code, followed
        /// by continents at the end of the list. 
        /// 
        ///  
        /// <para>
        ///  By default, the list of geo locations is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
        /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
        /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
        /// StartSubdivisionCode</code> to control the geo location that the list begins with.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations service method.</param>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListGeoLocationsResponse ListGeoLocations(ListGeoLocationsRequest request)
        {
            var marshaller = new ListGeoLocationsRequestMarshaller();
            var unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return Invoke<ListGeoLocationsRequest,ListGeoLocationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeoLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGeoLocations
        ///         operation.</returns>
        public IAsyncResult BeginListGeoLocations(ListGeoLocationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListGeoLocationsRequestMarshaller();
            var unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListGeoLocationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGeoLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGeoLocations.</param>
        /// 
        /// <returns>Returns a  ListGeoLocationsResult from Route53.</returns>
        public  ListGeoLocationsResponse EndListGeoLocations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGeoLocationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHealthChecks

        /// <summary>
        /// To retrieve a list of your health checks, send a <code>GET</code> request to the
        /// <code>2013-04-01/healthcheck</code> resource. The response to this request includes
        /// a <code>HealthChecks</code> element with zero, one, or multiple <code>HealthCheck</code>
        /// child elements. By default, the list of health checks is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the health check
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Route 53 endpoint. Please
        /// consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListHealthChecksResponse ListHealthChecks()
        {
            return ListHealthChecks(new ListHealthChecksRequest());
        }

        /// <summary>
        /// To retrieve a list of your health checks, send a <code>GET</code> request to the
        /// <code>2013-04-01/healthcheck</code> resource. The response to this request includes
        /// a <code>HealthChecks</code> element with zero, one, or multiple <code>HealthCheck</code>
        /// child elements. By default, the list of health checks is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the health check
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks service method.</param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Route 53 endpoint. Please
        /// consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest request)
        {
            var marshaller = new ListHealthChecksRequestMarshaller();
            var unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListHealthChecksRequest,ListHealthChecksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHealthChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHealthChecks
        ///         operation.</returns>
        public IAsyncResult BeginListHealthChecks(ListHealthChecksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListHealthChecksRequestMarshaller();
            var unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return BeginInvoke<ListHealthChecksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHealthChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHealthChecks.</param>
        /// 
        /// <returns>Returns a  ListHealthChecksResult from Route53.</returns>
        public  ListHealthChecksResponse EndListHealthChecks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHealthChecksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHostedZones

        /// <summary>
        /// To retrieve a list of your hosted zones, send a <code>GET</code> request to the <code>2013-04-01/hostedzone</code>
        /// resource. The response to this request includes a <code>HostedZones</code> element
        /// with zero, one, or multiple <code>HostedZone</code> child elements. By default, the
        /// list of hosted zones is displayed on a single page. You can control the length of
        /// the page that is displayed by using the <code>MaxItems</code> parameter. You can use
        /// the <code>Marker</code> parameter to control the hosted zone that the list begins
        /// with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        public ListHostedZonesResponse ListHostedZones()
        {
            return ListHostedZones(new ListHostedZonesRequest());
        }

        /// <summary>
        /// To retrieve a list of your hosted zones, send a <code>GET</code> request to the <code>2013-04-01/hostedzone</code>
        /// resource. The response to this request includes a <code>HostedZones</code> element
        /// with zero, one, or multiple <code>HostedZone</code> child elements. By default, the
        /// list of hosted zones is displayed on a single page. You can control the length of
        /// the page that is displayed by using the <code>MaxItems</code> parameter. You can use
        /// the <code>Marker</code> parameter to control the hosted zone that the list begins
        /// with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones service method.</param>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        public ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest request)
        {
            var marshaller = new ListHostedZonesRequestMarshaller();
            var unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesRequest,ListHostedZonesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHostedZones
        ///         operation.</returns>
        public IAsyncResult BeginListHostedZones(ListHostedZonesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListHostedZonesRequestMarshaller();
            var unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return BeginInvoke<ListHostedZonesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHostedZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHostedZones.</param>
        /// 
        /// <returns>Returns a  ListHostedZonesResult from Route53.</returns>
        public  ListHostedZonesResponse EndListHostedZones(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHostedZonesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHostedZonesByName

        /// <summary>
        /// To retrieve a list of your hosted zones in lexicographic order, send a <code>GET</code>
        /// request to the <code>2013-04-01/hostedzonesbyname</code> resource. The response to
        /// this request includes a <code>HostedZones</code> element with zero or more <code>HostedZone</code>
        /// child elements lexicographically ordered by DNS name. By default, the list of hosted
        /// zones is displayed on a single page. You can control the length of the page that is
        /// displayed by using the <code>MaxItems</code> parameter. You can use the <code>DNSName</code>
        /// and <code>HostedZoneId</code> parameters to control the hosted zone that the list
        /// begins with.
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName service method.</param>
        /// 
        /// <returns>The response from the ListHostedZonesByName service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// This error indicates that the specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListHostedZonesByNameResponse ListHostedZonesByName(ListHostedZonesByNameRequest request)
        {
            var marshaller = new ListHostedZonesByNameRequestMarshaller();
            var unmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesByNameRequest,ListHostedZonesByNameResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZonesByName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHostedZonesByName
        ///         operation.</returns>
        public IAsyncResult BeginListHostedZonesByName(ListHostedZonesByNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListHostedZonesByNameRequestMarshaller();
            var unmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return BeginInvoke<ListHostedZonesByNameRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHostedZonesByName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHostedZonesByName.</param>
        /// 
        /// <returns>Returns a  ListHostedZonesByNameResult from Route53.</returns>
        public  ListHostedZonesByNameResponse EndListHostedZonesByName(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHostedZonesByNameResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceRecordSets

        /// <summary>
        /// Imagine all the resource record sets in a zone listed out in front of you. Imagine
        /// them sorted lexicographically first by DNS name (with the labels reversed, like "com.amazon.www"
        /// for example), and secondarily, lexicographically by record type. This operation retrieves
        /// at most MaxItems resource record sets from this list, in order, starting at a position
        /// specified by the Name and Type arguments:
        /// 
        ///  <ul> <li>If both Name and Type are omitted, this means start the results at the first
        /// RRSET in the HostedZone.</li> <li>If Name is specified but Type is omitted, this means
        /// start the results at the first RRSET in the list whose name is greater than or equal
        /// to Name. </li> <li>If both Name and Type are specified, this means start the results
        /// at the first RRSET in the list whose name is greater than or equal to Name and whose
        /// type is greater than or equal to Type.</li> <li>It is an error to specify the Type
        /// but not the Name.</li> </ul> 
        /// <para>
        /// Use ListResourceRecordSets to retrieve a single known record set by specifying the
        /// record set's name and type, and setting MaxItems = 1
        /// </para>
        ///  
        /// <para>
        /// To retrieve all the records in a HostedZone, first pause any processes making calls
        /// to ChangeResourceRecordSets. Initially call ListResourceRecordSets without a Name
        /// and Type to get the first page of record sets. For subsequent calls, set Name and
        /// Type to the NextName and NextType values returned by the previous response. 
        /// </para>
        ///  
        /// <para>
        /// In the presence of concurrent ChangeResourceRecordSets calls, there is no consistency
        /// of results across calls to ListResourceRecordSets. The only way to get a consistent
        /// multi-page snapshot of all RRSETs in a zone is to stop making changes while pagination
        /// is in progress.
        /// </para>
        ///  
        /// <para>
        /// However, the results from ListResourceRecordSets are consistent within a page. If
        /// MakeChange calls are taking place concurrently, the result of each one will either
        /// be completely visible in your results or not at all. You will not see partial changes,
        /// or changes that do not ultimately succeed. (This follows from the fact that MakeChange
        /// is atomic) 
        /// </para>
        ///  
        /// <para>
        /// The results from ListResourceRecordSets are strongly consistent with ChangeResourceRecordSets.
        /// To be precise, if a single process makes a call to ChangeResourceRecordSets and receives
        /// a successful response, the effects of that change will be visible in a subsequent
        /// call to ListResourceRecordSets by that process.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ListResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        public ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest request)
        {
            var marshaller = new ListResourceRecordSetsRequestMarshaller();
            var unmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ListResourceRecordSetsRequest,ListResourceRecordSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceRecordSets
        ///         operation.</returns>
        public IAsyncResult BeginListResourceRecordSets(ListResourceRecordSetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListResourceRecordSetsRequestMarshaller();
            var unmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListResourceRecordSetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceRecordSets.</param>
        /// 
        /// <returns>Returns a  ListResourceRecordSetsResult from Route53.</returns>
        public  ListResourceRecordSetsResponse EndListResourceRecordSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceRecordSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReusableDelegationSets

        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>2013-04-01/delegationset</code> resource. The response to this request
        /// includes a <code>DelegationSets</code> element with zero, one, or multiple <code>DelegationSet</code>
        /// child elements. By default, the list of delegation sets is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the delegation
        /// set that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListReusableDelegationSetsResponse ListReusableDelegationSets()
        {
            return ListReusableDelegationSets(new ListReusableDelegationSetsRequest());
        }

        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>2013-04-01/delegationset</code> resource. The response to this request
        /// includes a <code>DelegationSets</code> element with zero, one, or multiple <code>DelegationSet</code>
        /// child elements. By default, the list of delegation sets is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the delegation
        /// set that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets service method.</param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        public ListReusableDelegationSetsResponse ListReusableDelegationSets(ListReusableDelegationSetsRequest request)
        {
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();
            var unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return Invoke<ListReusableDelegationSetsRequest,ListReusableDelegationSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReusableDelegationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReusableDelegationSets
        ///         operation.</returns>
        public IAsyncResult BeginListReusableDelegationSets(ListReusableDelegationSetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();
            var unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListReusableDelegationSetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReusableDelegationSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReusableDelegationSets.</param>
        /// 
        /// <returns>Returns a  ListReusableDelegationSetsResult from Route53.</returns>
        public  ListReusableDelegationSetsResponse EndListReusableDelegationSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReusableDelegationSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        public IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Route53.</returns>
        public  ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResources

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResources service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        public ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request)
        {
            var marshaller = new ListTagsForResourcesRequestMarshaller();
            var unmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourcesRequest,ListTagsForResourcesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResources
        ///         operation.</returns>
        public IAsyncResult BeginListTagsForResources(ListTagsForResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagsForResourcesRequestMarshaller();
            var unmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResources.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourcesResult from Route53.</returns>
        public  ListTagsForResourcesResponse EndListTagsForResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateHealthCheck

        /// <summary>
        /// This action updates an existing health check.
        /// 
        ///  
        /// <para>
        ///  To update a health check, send a <code>POST</code> request to the <code>2013-04-01/healthcheck/<i>health
        /// check ID</i></code> resource. The request body must include an XML document with an
        /// <code>UpdateHealthCheckRequest</code> element. The response returns an <code>UpdateHealthCheckResponse</code>
        /// element, which contains metadata about the health check.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the UpdateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckVersionMismatchException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        public UpdateHealthCheckResponse UpdateHealthCheck(UpdateHealthCheckRequest request)
        {
            var marshaller = new UpdateHealthCheckRequestMarshaller();
            var unmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<UpdateHealthCheckRequest,UpdateHealthCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHealthCheck
        ///         operation.</returns>
        public IAsyncResult BeginUpdateHealthCheck(UpdateHealthCheckRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateHealthCheckRequestMarshaller();
            var unmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateHealthCheckRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHealthCheck.</param>
        /// 
        /// <returns>Returns a  UpdateHealthCheckResult from Route53.</returns>
        public  UpdateHealthCheckResponse EndUpdateHealthCheck(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateHealthCheckResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateHostedZoneComment

        /// <summary>
        /// To update the hosted zone comment, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
        /// zone ID</i></code> resource. The request body must include an XML document with a
        /// <code>UpdateHostedZoneCommentRequest</code> element. The response to this request
        /// includes the modified <code>HostedZone</code> element.
        /// 
        ///  <note> The comment can have a maximum length of 256 characters.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment service method.</param>
        /// 
        /// <returns>The response from the UpdateHostedZoneComment service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        public UpdateHostedZoneCommentResponse UpdateHostedZoneComment(UpdateHostedZoneCommentRequest request)
        {
            var marshaller = new UpdateHostedZoneCommentRequestMarshaller();
            var unmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateHostedZoneCommentRequest,UpdateHostedZoneCommentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHostedZoneComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHostedZoneComment
        ///         operation.</returns>
        public IAsyncResult BeginUpdateHostedZoneComment(UpdateHostedZoneCommentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateHostedZoneCommentRequestMarshaller();
            var unmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateHostedZoneCommentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHostedZoneComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHostedZoneComment.</param>
        /// 
        /// <returns>Returns a  UpdateHostedZoneCommentResult from Route53.</returns>
        public  UpdateHostedZoneCommentResponse EndUpdateHostedZoneComment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateHostedZoneCommentResponse>(asyncResult);
        }

        #endregion
        
    }
}